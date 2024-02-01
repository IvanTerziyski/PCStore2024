namespace PCStore.Models.Models
{
    public record Manufacturer
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
