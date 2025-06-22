using kolokwiumPoprawkowe.DTOs;

namespace kolokwiumPoprawkowe.Services
{
    public interface IDbService
    {

        Task<GalleryInfoDTO> GalleryInfoAsync(int id);
    }
}
