     namespace MyApp
     {
            public class MiddleSchool : School
        {

            public int LowestGrade { get; set; }

            public int HighestGrade { get; set; }
    
            public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
                : base(name, principal, studentCount)
            {
                LowestGrade = lowestGrade;
                HighestGrade = highestGrade;
            }

        }

     }
