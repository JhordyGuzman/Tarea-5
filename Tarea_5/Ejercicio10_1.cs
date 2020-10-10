using System;

namespace Tarea_5.Tarea_5
{
    class Tienda
    {
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public String NombreProducto { get; set; }

        public Tienda()
        {
            Precio = 0;
            Unidades = 0;
            NombreProducto = string.Empty;
        }

        public Tienda(float precio, int unidades, String nombreProducto)
        {
            Precio = precio;
            Unidades = unidades;
            NombreProducto = nombreProducto;
        }

    }
    
}