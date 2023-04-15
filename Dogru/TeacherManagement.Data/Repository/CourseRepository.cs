using System;
using System.Collections.Generic;

namespace TeacherManagement.Data
{
    public class CourseRepository : ICourseRepository
    {
        Course ICourseRepository.GetCourseByCourseId(int Id)
        {
            throw new NotImplementedException();
        }

        List<Course> ICourseRepository.GetCourses()
        {
            throw new NotImplementedException();
        }

        Course ICourseRepository.InsertCourse(Course Course)
        {
            throw new NotImplementedException();
        }

        Course ICourseRepository.UpdateCourse(Course Course)
        {
            throw new NotImplementedException();
        }
    }
}