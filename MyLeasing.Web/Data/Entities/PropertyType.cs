using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Display(Name = "Propierty Type")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]

        public string Name { get; set; }

        /*
         * Relación con la entidad o clase Property
         * En el lado 1 se hace la relación con la propidad ICollection como se puede ver en la relación de 
         * propertytype con property
         */
        public ICollection<Property> Properties { get; set; }
    }
}
