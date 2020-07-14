﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examen1_GestorPaquetes.Model
{
    public class Persona
    {
        [Required(ErrorMessage = "La identificación es requerida")]
        [Display(Name = "Identificación")]
        [Key]
        public int Identificacion { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Primer Apellido es requerido")]
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "El Segundo Apellido es requerido")]
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        public byte[] Foto { get; set; }
    }
}
