using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3HerenciaG2_2024_1
{
    internal class Tractor: Transporte
    {
        #region Propiedades
        internal override int Velocidad
        {
            get => base.Velocidad;
            set
            {
                if (0 < value && value < 40)
                    velocidad = value;
                else
                    velocidad = 10;
            }
        }
        #endregion
        public Tractor()
        {
            combustible = 50;
            Arrancar();
            LimpiarDisplay();
            
            
        }
    }
}
