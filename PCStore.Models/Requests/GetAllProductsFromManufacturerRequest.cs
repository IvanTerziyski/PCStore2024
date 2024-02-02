namespace PCStore.Models.Requests
{
    public class GetAllProductsFromManufacturerRequest
    {
        public int ManufacturerId { get; set; }

        public DateTime DateAfter { get; set; }
    }
}
