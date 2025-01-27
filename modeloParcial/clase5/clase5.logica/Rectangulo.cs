﻿using System.ComponentModel.DataAnnotations;

namespace clase5.logica
{
    public class Rectangulo
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Base debe estar en un rango: 0 < x < 100.")]
        public int? Base { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Altura debe estar en un rango: 0 < x < 100.")]
        public int? Altura { get; set; }
        public int Area => (Base ?? 0) * (Altura ?? 0);

    }
}