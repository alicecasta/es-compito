using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_compito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane();
            cane.Nome = "Ringhio";
            cane.Razza = "labrador";
            cane.Proprietario.Nome = "Simone";
            
            //Persona p= new Persona();
            //p.Nome = "Simone";
        }
    }
}
