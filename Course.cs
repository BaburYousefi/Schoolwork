namespace Schoolwork
{
    public class Course
    {

        public string CourseNumber { get;  set; } ="";
        public string Titel { get; set; } ="";
        public string Classroom { get; set; } = "";
        public int LengthWeeks { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Distance { get; set; } 
        public List<Student> Deltagare { get; set; } = new List<Student>();

        public Course()
        {
            CourseNumber = GenerateCourseNumber();
        }

        private string GenerateCourseNumber()
        {
            return new Random().Next(1000, 7000).ToString();
        }

        public void AddDeltagare(Student student)
        {
            Deltagare.Add(student);
        }

        public void ListaDeltagare()
        {
            foreach (var deltagare in Deltagare)
            {
                Console.WriteLine(deltagare);
            }
        }

        public override string ToString()
        {

            return $"{Titel} (Kursnummer: {CourseNumber}), Längd: {LengthWeeks} veckor, Start: {StartDate.ToShortDateString()}, Slut: {EndDate.ToShortDateString()}, Distans: {(Distance ? "Ja" : "Nej")}";
        }

        public static List<Course> FindCourse()
        {
            return new List<Course>
            {
                new Course
                {
                    Titel = "Programmering",
                    LengthWeeks = 6,
                    StartDate = new DateTime(2024, 09, 15),
                    EndDate = new DateTime(2024, 10, 15),
                    Classroom = "Klassrum",
                    Distance = false 
                },
                new Course
                {
                    Titel = "Zoom",
                    LengthWeeks = 6,
                    StartDate = new DateTime(2024, 09, 1),
                    EndDate = new DateTime(2024, 10, 1),
                    Classroom = "Online",
                    Distance = true 
                }
            };
        }
    }


}


