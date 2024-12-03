namespace MishnatYosef.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AnotherPhone1 { get; set; }
        public string AnotherPhone2 { get; set; }
        public string AnotherPhone3 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string CreditCardNumber{ get; set; }
        public string CreditCardValidity{ get; set; }
        public int Cvv { get; set; }
        public int Station { get; set; }
        public string Identity { get; set; }

        public Customer(int id, string firstName, string lastName, string email, string phone, string anotherPhone1, string anotherPhone2, string anotherPhone3, string city, string zipcode, string creditCardNumber, string creditCardValidity, int cvv, int station, string identity)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            AnotherPhone1 = anotherPhone1;
            AnotherPhone2 = anotherPhone2;
            AnotherPhone3 = anotherPhone3;
            City = city;
            Zipcode = zipcode;
            CreditCardNumber = creditCardNumber;
            CreditCardValidity = creditCardValidity;
            Cvv = cvv;
            Station = station;
            Identity = identity;
        }
        public Customer()
        {
            
        }
    }
}
