using Business_Objects.Models;
using DAL.Context;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DAL
{
    public class DAL
    {
        AppDbContext _context = new AppDbContext();
        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void AddCourse(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }
        public void DeleteCourse(int id) 
        { 
            var course = _context.Courses.FirstOrDefault(x=>x.CourseId==id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
            _context.SaveChanges();
        }
        public Course GetRecordById(int id)
        {
            var course = _context.Courses.FirstOrDefault(x => x.CourseId == id);
            return course;

        }
        public Course EditCourse(int id,Course course)
        {
            var item = _context.Courses.ToList().Where(x => x.CourseId == id).FirstOrDefault();
            if (item != null)
            {
                
                    item.Description = course.Description;
                    item.Name = course.Name;
                    item.Module = course.Module;
                    _context.Courses.Update(item);
                _context.SaveChanges();
            }
            
            return course;


        }
    }
}
