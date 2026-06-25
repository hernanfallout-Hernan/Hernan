using System;
using System.Collections.Generic;
using System.Text;

namespace SUBE2
{
    internal class Beneficio
    {
        public class Beneficio
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public double PorcentajeDescuento { get; set; }

            public Beneficio(int id, string nombre, double porcentajeDescuento)
            {
                Id = id;
                Nombre = nombre;
                PorcentajeDescuento = porcentajeDescuento;
            }
            
          

        }

