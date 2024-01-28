using System;
using System.Collections.Generic;

class Aula26 {
    static void Main(){

        List<string> Carros = new List<string>();
        List<string> Carros2 = new List<string>();
        //string[] Carros2 = new string[7];

        Carros.Add("Golf");
        Carros.Add("Mercedes");
        Carros.Add("Lamborghini");
        Carros.Add("BMW");
        Carros.Add("Buggati");

        //Carros2.AddRange(Carros);

        //Carros.Clear();
        if(Carros.Contains("Golf")){
            Console.WriteLine("Esta na lista");
        } else {
            Console.WriteLine("Nao esta na lista");
        }

        //Carros.CopyTo(Carros2, 2);

        Carros.Insert(1, "Ferrari");
        int pos2 = Carros.LastIndexOf("Buggati");

         Carros.Remove("Buggati");
         Carros.RemoveAt(0);

         Carros.Reverse();
         Carros.Sort();

         int tamanho = Carros.Count;
         Console.WriteLine("Tamanho da lista: {0}", tamanho);

         int cap = Carros.Capacity;
         Console.WriteLine("Capacidade: {0}", cap);

        foreach(string c in Carros){
            Console.WriteLine("Carro: {0}" , c);
        }


        string ca = "Buggati";
        int pos = 0;
        pos = Carros.IndexOf(ca);
        Console.WriteLine("Carro: {0} esta na posicao {1}" , ca, pos);
        Console.WriteLine("O ultimo Buggati esta na posicao {0}",pos2);
    }
}