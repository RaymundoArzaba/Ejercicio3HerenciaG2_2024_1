using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3HerenciaG2_2024_1
{
    internal class Automovil : Transporte
    {
        #region Propiedades
        internal override int Velocidad 
        { 
            get => base.Velocidad; 
            set
            {
                if (0 < value && value < 200)
                    velocidad = value;
                else
                    velocidad = 100;
            }
        }
        #endregion
        public Automovil()
        {
            combustible = 20;
            Arrancar();
        }
    }
}
