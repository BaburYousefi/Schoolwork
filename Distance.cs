namespace Schoolwork
{
    public class Distance : Course
    {
        public string CourseDistance { get; set; } 

        
        public Distance(string titel, DateTime startDate, DateTime endDate, string zoom)
        {
            
            Titel = titel;
            StartDate = startDate;
            EndDate = endDate;
            CourseDistance = zoom; 
            
           
        }

       
        public override string ToString()
        {
            return $"{Titel} (Kursnummer: {CourseNumber}), Start: {StartDate.ToShortDateString()}, Slut: {EndDate.ToShortDateString()}, Distans: {CourseDistance}";
        }
        
      
       
    }
}
