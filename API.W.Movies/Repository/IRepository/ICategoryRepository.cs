using API.W.Movies.DAL.Models;

namespace API.W.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync(); //Me retorna UNA LISTA DE CATEGORIAS  
        Task<Category> GetCategoryAsync(int id); //Me retorna UNA CATEGORIA POR ID
        Task<bool> CategoryExistsByIdAsync(int id); //Me dice si existe una categoria por ID
        Task<bool> CategoryExistsByNameAsync(string name); //Me dice si existe una categoria por NOMBRE
        Task<bool> CreateCategoryAsync(Category category); //Me crea una categoria
        Task<bool> UpdateCategoryAsync(Category category); //Me crea una categoria --puedo actualizar el nombre y la fecha de actualizacion
        Task<bool> DeleteCategoryAsync(int id); //Me elimina una categoria
    }
}
