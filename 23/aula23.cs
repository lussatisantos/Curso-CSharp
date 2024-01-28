using System;
using System.Collections.Generic;

class Aula23 {
    static void Main(){

        Dictionary <int, string> veiculos = new Dictionary<int, string> ();

        veiculos.Add(10, "Carro");
        veiculos.Add(3, "Aviao");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(12, "Patinete");

        //veiculos.Clear(); LIMPA O DICTIONSARY

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        //veiculos.Remove(20);  REMOVER UM ITEM NA COLECAO

        
        //SE UMA CHAVE CONTEM NA COLECAO DICTIONARY
            int chave = 20;
            if(veiculos.ContainsKey(chave)){
                Console.WriteLine("A chave {0} esta na colecao", chave);
            } else {
                Console.WriteLine("A chave {0} nao esta na colecao", chave);
            }

            veiculos[14] = "Bicicleta";
        

        //SE UM VALOR ESTA NA COLECAO DICTIONARY
            string valor = "Bicicleta";
                if(veiculos.ContainsValue(valor)){
                    Console.WriteLine("A valor {0} esta na colecao", valor);
                } else {
                    Console.WriteLine("A valor {0} nao esta na colecao", valor);
                }
    
            Dictionary<int,string>.ValueCollection valores = veiculos.Values;

            foreach(string v in valores){
                Console.WriteLine(v);
            }

    /*
        foreach(KeyValuePair<int, string> v in veiculos) {
            Console.WriteLine(v);
        }
    */
    }
}