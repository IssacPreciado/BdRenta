using System.ComponentModel.DataAnnotations;

namespace BdRenta.Modelos
{
    public class Automovil
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del modelo es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Modelo { get; set; }
        [Required(ErrorMessage = "La matricula es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Matricula { get; set; }
        [Required(ErrorMessage = "Las especidifcaciones son requeridas")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]

        public string? Especificaciones { get; set; }

        //propiedad de navegacioon EF
        virtual public ICollection<Persona>? Personas { get; set; }
    }
}
