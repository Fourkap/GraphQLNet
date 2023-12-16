namespace GraphQL.Schema
{
    public enum Subject
    {
        Maths,
        History,
        Science
    }
    public class CourseType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public InstructorType Instructor { get; set; }
        public IEnumerable<StudentType> Students { get; set; }

        public string Awesome()
        {
            return "this is freaking awesome";
        }

    }
}
