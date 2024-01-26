using System;

class Area{
    public static float Quad(float bases, float altura){
        if(bases == 0 || altura == 0){
            throw new Exception("Base ou altura nao podem ser igual a 0");
        }

        return bases * altura;
    }
}

class Aula21 {
    static void Main(){

        float area = 0;

        try{
            area = Area.Quad(10F, 0F);
            Console.WriteLine("Area do quadrado: {0}" , area);
        } catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
        } finally{
            Console.WriteLine("Fim do processo");
        }

    }
}