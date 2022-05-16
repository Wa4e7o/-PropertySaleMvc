namespace PropertySalesSystem.Data.Model
{
    public class Dealer
    {
        public int Id { get; init; }

        public string Name { get; set; }

        public string Img { get; set; }

        public string PhoneNumber { get; set; }

        public string TypeOfSeller { get; set; }    

        public List<Property> Properties { get; set; } = new List<Property>();
    }
}
