using API.W.Movies.DAL.Models;

namespace API.W.Movies.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMoviesAsync(); // Me retorna UNA LISTA DE PELÍCULAS
        Task<Movie> GetMovieAsync(int id); // Me retorna UNA PELÍCULA POR ID
        Task<bool> CreateMovieAsync(Movie movie); // Me crea una película
        Task<bool> UpdateMovieAsync(Movie movie); // Me actualiza una película
        Task<bool> DeleteMovieAsync(int id); // Me elimina una película

    }
}
