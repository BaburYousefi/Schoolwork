namespace Schoolwork
{
    public class Person
    {
        public string FirstName { get; set; } ="";
        public string LastName { get; set; } ="";
        public string Phone { get; set; } ="";
        public string PersonalNumber { get; set; } ="";
        public string Address { get; set; }="";
        public string Postalcode { get; set; } = "";
        public string City { get; set; }="";

        public override string ToString()
        {
            return $"\nFörnamn: {FirstName}\nEfternamn: {LastName}\nTelefon: {Phone} \nAdress: {Address} \nPostcode: {Postalcode}\nStad: {City}";
        }
    }
}
