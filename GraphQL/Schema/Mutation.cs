namespace GraphQL.Schema
{
    public class Mutation
    {
        private readonly List<CourseType> _courses;
        public Mutation() 
        {
            _courses = new List<CourseType>();  
        }
        public bool CreateCourse(string name, Subject subject)
        {
            CourseType course = new CourseType()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Subject = subject,
                Instructor = new InstructorType()
                {
                    Id = Guid.NewGuid(),
                }
            };

            _courses.Add(course);
            return true;    
        }
    }
}
