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
        internal int velocidad;
        #endregion

        #region Propiedades
        internal virtual int Velocidad 
        { 
            get => velocidad; 
            set
            {
                if (0 < value && value < 100)
                    velocidad = value;
                else
                    velocidad = 30;
            } 
        }

        #endregion

        #region Metodos

        public void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        public string ElegirAccion()
        {
            string codigo = "";
            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("A:Acelerar\nB:Frenar");
            codigo = Console.ReadLine();
            return codigo;
        }

        public void TomarAccion(string codigo)
        {
            switch (codigo)
            {
                case "A":
                    Acelerar(Velocidad);
                    break;
                case "B":
                    Frenar(Velocidad);
                    break;
                default:
                    Console.WriteLine("Accion no valida");
                    break;
            }
        }
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

        public void Acelerar(int Velocidad)
        {
            Console.WriteLine("Velocidad anterior: {0}[m/s]\nVelocidad actual:{1}[km/hr]", Velocidad,Velocidad+1);
        }

        public void Frenar(int Velocidad)
        {
            Console.WriteLine("Velocidad anterior: {0}[m/s]\nVelocidad actual:{1}[km/hr]", Velocidad, Velocidad - 1);
        }

        #endregion
    }
}
