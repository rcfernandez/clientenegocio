﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyectoC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
    }
}