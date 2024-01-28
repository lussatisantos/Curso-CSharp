using System;
using System.Collections.Generic;

class Aula27{
    static void Main(){

        //string[] vs = {"Carro", "Moto", "Navio", "Aviao"};
        Queue<string>veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Aviao");

        string v = "Patinete";
        if(veiculos.Contains(v)){
            Console.WriteLine("Encontrado");
        } else {
            Console.WriteLine("Nao encontrado");
        }

        //veiculos.Clear();

        //Console.WriteLine("Primeiro veiculo: {0}", veiculos.Dequeue());
        //Console.WriteLine("Primeiro veiculo: {0}", veiculos.Dequeue());

        Console.WriteLine("Primeiro veiculo: {0}", veiculos.Peek());

        foreach(string a in veiculos){
            //v = veiculos.Dequeue();
            Console.WriteLine("Veiculo: {0}", a);
        }

        Console.WriteLine("Tamanho fila: " + veiculos.Count);

        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }

        Console.WriteLine("Tamanho fila: " + veiculos.Count);
    }
}