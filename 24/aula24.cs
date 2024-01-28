using System;
using System.Collections.Generic;

class Aula24 {
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no = transp.FindLast("Navio");
        transp.AddAfter(no, "Patinete");

         no = transp.FindLast("Navio");
        transp.AddBefore(no, "Patins");

        //transp.Clear();
        if((transp.Find("Carro")) == null){
            Console.WriteLine("Nao encontrado");
        } else {
            Console.WriteLine("Elemento encontrado");
        }

        transp.Remove("Navio");
        transp.RemoveFirst();//Remove first element
        transp.RemoveLast(); //Remove last element

        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);
        }

    }
}