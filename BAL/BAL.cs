using Business_Objects.Models;
using DAL;
namespace BAL
{
    
    public class BAL
    {
        DAL.DAL dal = new DAL.DAL();
        public List<Course> GetAllCourses()
        {
            return dal.GetAllCourses();
        }
        public void AddCourses(Course course)
        {
            dal.AddCourse(course);
        }
        public void DeleteCourse(int id)
        { 
            dal.DeleteCourse(id);
        }
        public Course GetRecordById(int id)
        {
            return dal.GetRecordById(id);
        }
        public Course EditCourse(Course course,int id)
        {
            return dal.EditCourse(id, course);
        }
    }
}
