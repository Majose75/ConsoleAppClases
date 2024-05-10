using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Modelo
{
    public class Coche
    {
        //Constructor
        public Coche(string matricula, bool cabe=false)
        {
            Matricula = matricula;
            Cabe = cabe;
        }
        public Coche() { }  //Constructor por defecto

        ////Solo recuperar el valor --> public string matricula2 { get; }

        /// // El coche va a tener una propiedad que se va a poder meter y recuperar  Lectura y escritura.  Si e pusioera String, al ser un bojeto no se iniciaria con " ".</summary>
        public string Matricula { get; set; }  
        public bool Cabe { get; set; } = false;  

       public override string ToString()  // Sobreescribe el toString a como le decimos.
        {
                return "Matricula: " + this.Matricula + ", " + this.Cabe;
        }
//Determina si un objeto es igual a otro segun el criterio que se designe, en este caso matricula.
        public override bool Equals(object? obj)
        {
            return obj is Coche coche && Matricula == coche.Matricula;
        }
// Determina si en mayor o menor. Lo ordena por matricula, en este caso.
        public int CompareTo(Coche other) 
        {
                return this.Matricula.CompareTo(other.Matricula);
        }

    }
}
