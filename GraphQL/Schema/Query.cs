using Bogus;

namespace GraphQL.Schema
{
    public class Query
    {

        public IEnumerable<CourseType> GetCourses()
        {
            Faker<CourseType> courseFaker = new Faker<CourseType>()
                .RuleFor(c => c.Id, f => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Name.FullName());
            List<CourseType> courses = courseFaker.Generate(5);
            return courses;
        }

        public CourseType GetCourseById(Guid id)
        {
            Faker<CourseType> courseFaker = new Faker<CourseType>();
            CourseType course = courseFaker.Generate();

            course.Id = id;
            return course;
        }
    }
}
