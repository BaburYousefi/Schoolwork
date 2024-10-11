namespace Schoolwork
{
    public class Student : Person
    {


        public override string ToString()
        {
            return $"\nFörnamn: {FirstName} \nEfternamn: {LastName}\nTelefon: {Phone} \nAdress: {Address}\nPostnummer: {Postalcode} \nOrt: {City}";
        }
    }
    }

