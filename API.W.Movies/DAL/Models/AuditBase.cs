using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AuditBase
    {
        [Key] //Este data annotation indica que el campo es obligatorio
        public virtual int Id { get; set; }


        public virtual DateTime CreatedDate { get; set; } 


        public virtual DateTime? ModifiedDate { get; set; } 


    }
}
