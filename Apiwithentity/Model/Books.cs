namespace Apiwithentity.Model
{
    public class Books
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public String Title { get; set; }
        public String ISBN { get; set; }
        public String Year { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }

        public string Position { get; set; }

        public String Status { get; set; }
        public String Image { get; set; }
    }
}
