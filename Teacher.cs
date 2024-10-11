

namespace Schoolwork
{
    public class Teacher : Person
    {
        public string ResponsibleAre { get; set; } = "";
        public List<string> ResponsibleCourses { get; set; } = new List<string>();

        
        




        public override string ToString()
        {
            return $" \nKunskapsområde: {ResponsibleAre}\n Ansvariga kurser: {ResponsibleCourses}";
        }
    }
}
