﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercio
{
    internal class Articulo
    {
        public int CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string UrlImagen { get; set; }
        public float Precio { get; set; }
    }
}
