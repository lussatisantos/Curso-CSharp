using System;

class Aula {
    static void Main(){
        int v1, v2;
        string nome;

        Console.WriteLine("..........................");
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("O seu nome: {0}", nome);

        Console.WriteLine("..........................");
        Console.WriteLine("Faca um pequeno calculo");
        Console.WriteLine("..........................");

        Console.Write("Digite o primeiro numero: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("..........................");
        Console.WriteLine("A soma de {0} por {1} sera igual a {2}", v1, v2, v1+v2);
        Console.WriteLine("..........................");
    }
}