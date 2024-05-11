using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smartphone;

namespace SmartphoneNokia
{
    public class Nokia : Smartphone1 
    {
        public void ReceberLigação() {
            Console.WriteLine("Recebendo ligação...");
        }
        public void Ligar() {
            Console.Write("Disque um número para realizar uma liagação:");
            Numero = Console.ReadLine();
            Console.WriteLine("Ligando para "+ Numero);
        }
        public void MemoriaNokia() {
            Console.WriteLine("Memoria: 128");
        
        }

        public void ModeloNokia() {
            Console.WriteLine("Modelo: Nokia");
            
        }


         public void IMEINokia() {
            Console.WriteLine("IMEI: 123456789");
            
        }
        public override void InstalarAplicativo()
        {
            Console.Write("Digite o nome do aplicativo para realizar a instalação:");
            string intalacao = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Fazendo a instalação do App "+ intalacao);
        }
    }
}