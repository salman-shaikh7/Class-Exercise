    namespace MyApp
    {
        public class SportsSchool : School
        {
            public string SportsFieldName { get; set; }

            public SportsSchool(string name, string principal, int studentCount, string sportsFieldName)
                : base(name, principal, studentCount)
            {
                SportsFieldName = sportsFieldName;
            }

        }

    }