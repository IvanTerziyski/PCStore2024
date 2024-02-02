using PCStore.Models.Requests;
using PCStore.Models.Responces;

namespace PCStore.BL.Interfaces
{
    public interface IStoreService
    {
        GetAllProductsFromManufacturerResponce
            GetAllProductsFromManufacturerAfterReleaseDate(GetAllProductsFromManufacturerRequest request);

        public int CheckProductCount(int input);
    }
}
