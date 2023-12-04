using System;

class Aula18 {
    static void Main() {

        //soma();
        //soma(10);
        soma(10,4,2,9);
    }

    static void soma(params int[]n){
        int res = 0;

        if(n.Length < 1) {
            Console.WriteLine("Nao ha valor a serem somados");
        } else if(n.Length < 2) {
            Console.WriteLine("Argumento insuficientes para soma: {0}", n[0]);
        } else {
            for(int i = 0; i < n.Length; i++) {
                res += n[i];
            }

            Console.WriteLine("A soma dos valores sera {0}", res);
        }

        
    }
}