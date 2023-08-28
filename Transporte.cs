using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3HerenciaG2_2024_1
{
    internal abstract class Transporte
    {
        #region Atributos
        public byte combustible;
        private bool Encendido=false;

        #endregion

        #region Metodos

        public void Arrancar()
        {
            if(combustible == 0)
            {
                Console.WriteLine("No hay combustible");
            }
            else
            {
                Encendido = true;
                Console.WriteLine("Motor encendido");
            }
        }

        #endregion
    }
}
