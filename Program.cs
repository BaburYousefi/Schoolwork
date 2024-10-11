namespace Schoolwork
{
    class Program
    {
        static void Main()
        {
            List<Course> kurser = Course.FindCourse(); 
            List<Student> studenter = new List<Student>();

            while (true)

            {
                Console.WriteLine("\n----- Huvudmeny --------");
                Console.WriteLine("1. Visa klassrumsbaserade kurser");
                Console.WriteLine("2. Visa distanskurser");
                Console.WriteLine("3. Lägg till student i en kurs");
                Console.WriteLine("4. Avsluta");

                Console.Write("\nAnge ditt val: ");
                string? val = Console.ReadLine(); 

                if (val == "1")
                {
                    vissklasser(kurser); 
                }
                else if (val == "2")
                {
                    vissaDistance(kurser); 
                }
                else if (val == "3")
                {
                    addstudent(kurser, studenter); 
                }
                else if (val == "4")
                {
                   
                    Console.WriteLine("Programmet avslutas...");
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                }
            }
        }

        static void vissklasser(List<Course> kurser)
        {
            Console.WriteLine("\nKlassrumsbaserade kurser:");
            foreach (var kurs in kurser)
            {
                if (!kurs.Distance) 
                {
                    Console.WriteLine(kurs.ToString()); 
                }
            }
        }

        static void vissaDistance(List<Course> kurser)
        {
            Console.WriteLine("\nDistanskurser:");
            foreach (var kurs in kurser)
            {
                if (kurs.Distance) 
                {
                    Console.WriteLine(kurs.ToString()); 
                }
            }
        }

        static void addstudent(List<Course> kurser, List<Student> studenter)
        {
            Console.WriteLine("\nVälj en kurs för att lägga till en student:");
            foreach (var kurs in kurser)
            {
                Console.WriteLine($"- {kurs.Titel}");
            }

            Console.Write("\nAnge kursens namn: ");
            string? kursNamn = Console.ReadLine();

            Course? valdKurs = Findcoruse(kurser, kursNamn);

            if (valdKurs != null)
            {
                Student student = SkapaStudent();
                valdKurs.AddDeltagare(student);
                studenter.Add(student);
                Console.WriteLine("Student tillagd i kursen.");
            }
            else
            {
                Console.WriteLine("Kursen hittades inte. Försök igen.");
            }
        }

        static Course? Findcoruse(List<Course> kurser, string? kursNamn)
        {
            if (string.IsNullOrEmpty(kursNamn))
            {
                return null;
            }

            foreach (var kurs in kurser)
            {
                if (kurs.Titel.ToLower() == kursNamn.ToLower())
                {
                    return kurs;
                }
            }
            return null;
        }

        static Student SkapaStudent()
        {
            Console.Write("Ange förnamn: ");
            string? firstName = Console.ReadLine();
            Console.Write("Ange efternamn: ");
            string? lastName = Console.ReadLine();
            Console.Write("Ange telefon: ");
            string? phone = Console.ReadLine();
            Console.Write("Ange personnummer: ");
            string? personalNumber = Console.ReadLine();
            Console.Write("Ange adress: ");
            string? address = Console.ReadLine();
            Console.Write("Ange postnummer: ");
            string? postalCode = Console.ReadLine();
            Console.Write("Ange ort: ");
            string? city = Console.ReadLine();

            
            return new Student
            {
                FirstName = firstName ??  "",
                LastName = lastName ?? "",
                Phone = phone ?? "",
                PersonalNumber = personalNumber ?? "",
                Address = address ?? "",
                Postalcode = postalCode ?? "",
                City = city ?? "",
            };
        }
        
    }
}
