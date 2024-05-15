using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Coleccion01 : IColeccion
    {
        public List<IMilitable> elementoMilitar { get; set; } = new List<IMilitable>();
        int totalElementos = 0;
        double totalPotencia = 0;
        double totalBlindaje = 0;
        double totalMovimiento = 0;
        double totalGastado = 0;
        //double CM = 0;
        string nombreDivision = "";
        public bool Add(IMilitable elemento)
        {
            if(elemento != null)
            {
                elementoMilitar.Add(elemento);
                totalElementos++;
                totalPotencia += elemento.PotenciaFuego;
                //Console.WriteLine(elemento.PotenciaFuego + totalPotencia.ToString());
                totalBlindaje += elemento.Blindaje;
                totalMovimiento += elemento.Movimiento;
                totalGastado += elemento.Precio;
                //CM += elemento.CapacidadMilitar();
                //nombreDivision= elementoMilitar.
                return true;
            }
            else
            {
                return false;
            }

        }

        public double CapacidadMilitar()
        {
            //return this.CM;
            return ((totalPotencia * totalMovimiento) / 2) / (100 - totalBlindaje);
        }

        public double DameBlindajeTotal()
        {
            return totalBlindaje;
        }

        public double DameMovimientoTotal()
        {
            return totalMovimiento;
        }

        public int DameElementos()
        {
            return totalElementos;
        }

        public double DamePotenciaTotal()
        {
            return totalPotencia;
        }

        public double TotalGastado()
        {
            return totalGastado;
        }

    }
}