using System;

class Aula12{
    static void Main(){

        int[] n = new int[4];
        int[] num = new int[3]{999, 777, 888};
        int[] nume = {900, 800, 700};
        string[] veiculos = new string[3];

        veiculos[0] = "Carro";
        veiculos[1] = "Aviao";
        veiculos[2] = "Navio";

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;

        Console.WriteLine(n[0]);
        Console.WriteLine(n[3]);
        Console.WriteLine(num[0]);
        Console.WriteLine(nume[2]);
        Console.WriteLine(nume[0]);
        Console.WriteLine(veiculos[0]);
        Console.WriteLine(veiculos[1]);
    }
}