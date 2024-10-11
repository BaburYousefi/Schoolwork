namespace Schoolwork
{
    public class Handledare : Teacher
    {
        public DateTime EmploymentDate { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Anställningsdatum: {EmploymentDate.ToShortDateString()}";
        }
    }
}
