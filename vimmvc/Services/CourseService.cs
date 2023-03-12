using Core.Application.Interfaces;

namespace vimmvc.Services
{
	public class CourseService
	{
		private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
    }
}
