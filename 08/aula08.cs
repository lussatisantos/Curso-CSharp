using System;

class Aula08 {
    
    enum DiasSemana{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};

    static void Main(){

        DiasSemana ds = DiasSemana.Domingo;
        Console.WriteLine(ds);

        DiasSemana no = (DiasSemana)3;
        Console.WriteLine(no);

        int da =(int)DiasSemana.Sexta;
        Console.WriteLine(da);
    }
}