namespace Adressbok.Classes
{
    public class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        #endregion

        #region Constructors
        public Person()
        {

        }
        public Person(string firstName, string lastName, string address, string zipCode, string city, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Phone = phone;
            Email = email;
        }
        #endregion

        #region Methods
        public void AddPerson(List<Person> people)
        {
            FileManager fileManager = new FileManager(@"C:\temp\address.txt");
            string row = $"{FirstName},{LastName},{Address},{ZipCode},{City},{Phone},{Email}";
            fileManager.WriteFile(people, row);
        }
        private bool CheckEmail() //Check ifall email innehåller "@" samt en "."
        {
            if (Email.Contains('@') && Email.Contains('.'))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Felaktigt Email");
                return false;
            }
        }
        #endregion
    }
}
