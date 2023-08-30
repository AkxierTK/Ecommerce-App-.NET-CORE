using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        /* Data Anotation permite que declaremos las restricciones de la tabla
         * Ejmp : [KEY] Quien es la Primary Key o si es el nombre de la clase + Id CategoryId lo asignará automáticamente 
          Más info en  https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6     
         */
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Te value Must to be between 1-100")]
        public int DisplayOrder { get; set; }

    }
}
