﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UPCNETSystemCliente.Business_Entities
{
    public class HorarioProfesor
    {
        public string IDCurso { get; set; }
        public string Nombre { get; set; }
        public string Dia { get; set; }
        public DateTime HoraIni { get; set; }
        public DateTime HoraFin { get; set; }
    }
}