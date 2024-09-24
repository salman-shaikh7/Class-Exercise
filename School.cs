namespace MyApp
{
        public class School
    {

        public string Name { get; set; }

        public string Principal { get; set; }

        public int StudentCount { get; set; }

        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

    }

}
