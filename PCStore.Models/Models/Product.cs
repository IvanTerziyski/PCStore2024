namespace PCStore.Models.Models
{
    public record Product
    {
        public int Id { get; set; } 
        public string ProductName { get; set; } = string.Empty;

        public int ManufacturerId { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}
