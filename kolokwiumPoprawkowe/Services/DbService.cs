using kolokwiumPoprawkowe.Data;
using kolokwiumPoprawkowe.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace kolokwiumPoprawkowe.Services
{
    public class DbService : IDbService
    {
        private readonly DatabaseContext _context;

        public DbService(DatabaseContext context)
        {
            _context = context;
        }


        public async Task<GalleryInfoDTO> GalleryInfoAsync(int id)
        {
            var info = await _context.Galleries.Select(g => new GalleryInfoDTO
            {

                Id = id,
                Name = g.Name,
                EstablishedDate = g.EstablishedDate,
                ExhibitionsDTO = g.Exhibition.Select(e => new ExhibitionInfoDTO
                {
                    Title = e.Title,
                    StartDate = e.StartDate,
                    EndDate = (DateTime)e.EndDate,
                    NumberOfArtworks = e.NumberOfArtworks,
                    
                }).ToList(),
      

            }).FirstOrDefaultAsync(e => e.Id == id);

            if (info is null)
            {
                throw new Exception("brak wartosci");
            }

            return info;

        }
    }
}
