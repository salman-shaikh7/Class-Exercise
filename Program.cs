using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   
    
            School mySchool = new School("Green Valley High", "Mrs. Smith", 500);

            MiddleSchool middleSchool = new MiddleSchool("Central Middle School", "Mr. Adams", 300, 6, 8);

            SportsSchool sportsSchool = new SportsSchool("Olympia High", "Coach Carter", 800, "Olympic Stadium");

            Console.WriteLine(mySchool.Name);
            Console.WriteLine(mySchool.Principal);
            Console.WriteLine(mySchool.StudentCount);
        }
    }
}

