using System.ComponentModel.DataAnnotations;

namespace Clase3.tarea.web.Models
{
    public class FormularioViewModel
    {
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(50, ErrorMessage = "El campo Nombre no puede superar los 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es requerido")]
        [StringLength(50, ErrorMessage = "El campo Apellido no puede superar los 50 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Email es requerido")]
        [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo válida")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es requerido")]
        [StringLength(100, ErrorMessage = "El campo Contraseña debe tener al menos {2} caracteres.", MinimumLength = 6)]
        public string Contraseña { get; set; }

        [Required(ErrorMessage = "El campo Confirmar Contraseña es requerido")]
        [Compare("Contraseña", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarContraseña { get; set; }


    }
}
