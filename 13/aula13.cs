using System;

class Aula13{
    static void Main(){

        int[,] n = new int[4, 3];

        /*
            1 2 4
            3 4 7
            0 9 0
            8 7 1
        */

        n[0, 0] = 1;
        n[0, 1] = 2;
        n[0, 2] = 4;

        n[1, 0] = 3;
        n[1, 1] = 4;
        n[1, 2] = 7;

        n[2, 0] = 0;
        n[2, 1] = 9;
        n[2, 2] = 0;

        n[3, 0] = 8;
        n[3, 1] = 7;
        n[3, 2] = 1;


        for(int i = 0; i < 4; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write(n[i, j]);
            }
        }
    }
}