using System;
using System.Collections.Generic;

class Aula25 {
    static void Main(){

        List<string> Carros = new List<string>();
        List<string> Carros2 = new List<string>();
        //string[] Carros2 = new string[7];

        Carros.Add("Golf");
        Carros.Add("Mercedes");
        Carros.Add("Lamborghini");
        Carros.Add("BMW");

        //Carros2.AddRange(Carros);

        //Carros.Clear();
        if(Carros.Contains("Golf")){
            Console.WriteLine("Esta na lista");
        } else {
            Console.WriteLine("Nao esta na lista");
        }

        //Carros.CopyTo(Carros2, 2);

        foreach(string c in Carros2){
            Console.WriteLine("Carro: {0}" , c);
        }

        string ca = "Buggati";
        int pos = 0;
        pos = Carros.IndexOf(ca);
        Console.WriteLine("Carro: {0} esta na posicao {1}" , ca, pos);
    }
}