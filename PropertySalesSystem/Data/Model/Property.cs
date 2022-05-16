namespace PropertySalesSystem.Data.Model
{
    public class Property
    {
        public int Id { get; init; }

        public string Title { get; set; }

        public string Area { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public int DealerId {get; set;}

        public Dealer Dealer { get; set; }  

    }
}
