using System;
using Smartphone;
using SmartphoneIphone;
using SmartphoneNokia;

Iphone1 aplle = new Iphone1();
Nokia nokia = new Nokia();

Console.Write("Escolha um sistema operacional: ");
string escolha = Console.ReadLine();

 bool exibirMenu = true;

if (escolha == "Iphone") {
    
    while (exibirMenu) {

    Console.Clear();
    Console.WriteLine("1. IMEI");
    Console.WriteLine("2. Memória");
    Console.WriteLine("3. Fazer Ligação");
    Console.WriteLine("4. Instalar aplicativos");
    Console.WriteLine("5. Exibir ficha técnica completa");
    Console.WriteLine("6. Sair");

    
    switch (Console.ReadLine()) {
        case"1":
        aplle.IMEI();
        break;
        case"2" :
        aplle.MemoriaAplle();
        break;
        case"3" :
        aplle.Ligar();
        break;
        case"4" :
        aplle.InstalarAplicativo();
        break;
        case"5" :
        aplle.ModeloAplle();
        aplle.MemoriaAplle();
        aplle.IMEI();
        break;
        case"6" :
        exibirMenu = false;
        break;
        default :
        Console.WriteLine("Opção inválida");
        break;
    }
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadLine();
    
}
    
}
else {
     while (exibirMenu) {

    Console.Clear();
    Console.WriteLine("1. IMEI");
    Console.WriteLine("2. Memória");
    Console.WriteLine("3. Fazer Ligação");
    Console.WriteLine("4. Instalar aplicativos");
    Console.WriteLine("5. Exibir ficha técnica completa");
    Console.WriteLine("6. Sair");

    
    switch (Console.ReadLine()) {
        case"1":
        nokia.IMEINokia();
        break;
        case"2" :
        nokia.MemoriaNokia();
        break;
        case"3" :
        nokia.Ligar();
        break;
        case"4" :
        nokia.InstalarAplicativo();
        break;
        case"5" :
        nokia.ModeloNokia();
        nokia.MemoriaNokia();
        nokia.IMEINokia();
        break;
        case"6" :
        exibirMenu = false;
        break;
        default :
        Console.WriteLine("Opção inválida");
        break;
    }
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para continuar");
        Console.ReadLine();
    
}
   

}




