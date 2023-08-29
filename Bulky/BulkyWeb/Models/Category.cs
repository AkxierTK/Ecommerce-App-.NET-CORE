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
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
