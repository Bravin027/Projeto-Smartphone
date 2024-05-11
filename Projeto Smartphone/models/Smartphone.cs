using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone
{
    public abstract class Smartphone1
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        public void Ligar() {
            Console.Write("Disque um número para realizar uma liagação:");
            Numero = Console.ReadLine();
        }
        public void ReceberLigação() {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo();

        
        
    }
}