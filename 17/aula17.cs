using System;

class Aula16 {
    static void Main() {
        
        int dividend;
        int divis;
        int quo;
        int rest;

        dividend = 10;
        divis = 2;
        quo = divide(dividend, divis, out rest);

        Console.WriteLine("{0} / {1} : quociente={2} e resto={3}", dividend, divis, quo, rest);
    }

    static int divide(int dividendo, int divisor, out int resto) {
        int quociente;
        quociente = dividendo / divisor;

        resto = dividendo % divisor;

        return quociente;
    }
}