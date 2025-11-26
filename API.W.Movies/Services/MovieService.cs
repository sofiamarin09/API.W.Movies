using API.W.Movies.DAL.Models;
using API.W.Movies.DAL.Models.Dtos;
using API.W.Movies.Repository.IRepository;
using API.W.Movies.Services.IServices;
using AutoMapper;

namespace API.W.Movies.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<MovieDto>> GetMoviesAsync()
        {
            var movies = await _movieRepository.GetMoviesAsync();
            return _mapper.Map<ICollection<MovieDto>>(movies);
        }

        public async Task<MovieDto> GetMovieAsync(int id)
        {
            var movie = await _movieRepository.GetMovieAsync(id);

            if (movie == null)
            {
                throw new InvalidOperationException($"No se encontró la película con ID: '{id}'");
            }

            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<MovieDto> CreateMovieAsync(MovieCreateUpdateDto movieCreateDto)
        {
            var movie = _mapper.Map<Movie>(movieCreateDto);

            var created = await _movieRepository.CreateMovieAsync(movie);

            if (!created)
            {
                throw new Exception("Ocurrió un error al crear la película.");
            }

            return _mapper.Map<MovieDto>(movie);
        }

        public async Task<MovieDto> UpdateMovieAsync(MovieCreateUpdateDto dto, int id)
        {
            var movieExists = await _movieRepository.GetMovieAsync(id);

            if (movieExists == null)
            {
                throw new InvalidOperationException($"No se encontró la película con ID: '{id}'");
            }

            _mapper.Map(dto, movieExists);

            var updated = await _movieRepository.UpdateMovieAsync(movieExists);

            if (!updated)
            {
                throw new Exception("Ocurrió un error al actualizar la película.");
            }

            return _mapper.Map<MovieDto>(movieExists);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movieExists = await _movieRepository.GetMovieAsync(id);

            if (movieExists == null)
            {
                throw new InvalidOperationException($"No se encontró la película con ID: '{id}'");
            }

            var deleted = await _movieRepository.DeleteMovieAsync(id);

            if (!deleted)
            {
                throw new Exception("Ocurrió un error al eliminar la película.");
            }

            return deleted;
        }
    }
}