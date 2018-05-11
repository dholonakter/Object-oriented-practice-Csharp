namespace WindowsFormsApp1
{
    public class Person
    {
        #region fields
        private string city;
        private int housenumber;
        private int id;
        private string name;
        private string postalcode;
        private string street;
        #endregion


        #region Properties
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        #endregion

        #region Constructor
        public Person(int id, string name, string street, int housenumber, string postalcode, string city)
        {

        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return "name";


        }
        #endregion





    }
}
