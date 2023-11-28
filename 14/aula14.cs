using System;

class Aula14{
    static void Main() {
        
        int[] num = new int[] { 1, 2, 3, 4};
        /*
        int[] num = new int[] { 1, 2, 3, 4};

        for(int i = 0; i < num.Length; i++) {
            Console.WriteLine(num[i]);
        }
        */

        foreach(int n in num){
            Console.WriteLine(n);
        }
    }
}