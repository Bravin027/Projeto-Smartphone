using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smartphone;

namespace SmartphoneIphone 
{
    public class Iphone1  : Smartphone1
    {
        public void ReceberLigação() {
            Console.WriteLine("Recebendo ligação...");
        }
        public void Ligar() {
            Console.Write("Disque um número para realizar uma liagação:");
            Numero = Console.ReadLine();
            Console.WriteLine("Ligando para "+ Numero);
        }

        public void IMEI() {
            Console.WriteLine("IMEI: 12345678");
             
        }
        public void ModeloAplle() {
            Console.WriteLine("Modelo: Iphone");
            
        }
        public void MemoriaAplle() {
            Console.WriteLine("Memoria: 256");
             
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