using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SoupLocal._1_Core.Entities;

namespace SoupLocal._3_Data.Data.Interface
{
    public interface ICourseRepository
    {
        public string CreateCourse();
        public string GetCourse();
        public string GetCourseByCategory();
        public string GetCourseById();
        /*        public Task<Course> UpdateCourse(Course course);
                public Task<bool> DeleteCourse(int id);*/

    }
}
