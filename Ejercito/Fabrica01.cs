using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercito
{
    public class Fabrica01 : IFabrica
    {
        public IValidable Validador { get; set; }
        public Fabrica01(IValidable Validador)
        { 
            this.Validador = Validador;
        }

        public IMilitable dameInstancia(EnumDivisiones divisiones, string nombre, double movimiento, double blindaje, double potencia, double precio)
        {
            IMilitable militable = null;
            switch (divisiones)
            {
                case EnumDivisiones.Artilleria:
                    militable = new Artilleria(nombre, movimiento, blindaje, potencia, precio); break;
                case EnumDivisiones.Caballeria:
                    militable = new Caballeria(nombre, movimiento, blindaje, potencia, precio);
                    //Console.WriteLine(militable.Blindaje);
                    break;
                case EnumDivisiones.Infanteria:
                    militable = new Infanteria(nombre, movimiento, blindaje, potencia, precio); break;
            }
            if (Validador.isValid(militable))
            {
                return militable;
            }
            else
            {
                return null;
            }
        }
    }
}