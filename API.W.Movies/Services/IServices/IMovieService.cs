using API.W.Movies.DAL.Models.Dtos;

namespace API.W.Movies.Services.IServices
{
    public interface IMovieService
    {
        Task<ICollection<MovieDto>> GetMoviesAsync();
        Task<MovieDto> GetMovieAsync(int id);
        Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieDto);
        Task<MovieDto> UpdateMovieAsync(MovieCreateUpdateDto dto, int id);
        Task<bool> DeleteMovieAsync(int id);
    }
}