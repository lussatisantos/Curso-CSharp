using System;

class Aula11 {
    static void Main() {
        
        int tempo = 0;
        char escolha = ' ';

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.Write("Escolha o transporte: [a]Aviao | [c] Carro | [o] Onibus :  ");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha){
            case 'a':
            case 'A':
                tempo = 40;
                break;
            case 'c':
                tempo = 480;
                break;
            case 'o':
                tempo = 720;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0) {
            Console.WriteLine("Transporte indisponivel");
        } else {
            Console.WriteLine("O tempo para transporte escolhido sera: {0} minutos", tempo);
        }

        Console.Write("Calcular outro transporte? [s/n]: ");
        escolha = char.Parse(Console.ReadLine());
        if  (escolha == 's' || escolha == 'S') {
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("Fim do programa!");
        }
    }
}