package algoritmo007;

import java.util.Scanner;

public class Main {
    public static void executar(){
        Scanner scanner = new Scanner(System.in);

        System.out.println("Ler a prova.");
        System.out.print("Quantas questões tem na prova? ");

        int numeroDeQuestoes = Integer.parseInt(scanner.nextLine());
        int contadorDeQuestoes = 1;
        int tempoParaProva = 60;

        while (numeroDeQuestoes > 0 && tempoParaProva > 0){
            System.out.print("Você sabe responder a %dª questão? (s/n)".formatted(contadorDeQuestoes));
            String resposta = scanner.nextLine();

            if(resposta.equalsIgnoreCase("s")){
                System.out.println("Questão: %d respondida.".formatted(contadorDeQuestoes));
                tempoParaProva -= 3;
            } else {
                System.out.println("Você pulou a questão: %d.".formatted(contadorDeQuestoes));
                tempoParaProva -= 1;
            }

            contadorDeQuestoes++;
            numeroDeQuestoes--;
        }

        if (tempoParaProva <= 0) {

            System.out.println("O tempo acabou.");
            System.out.println("Entregar a prova.");

        } else if (numeroDeQuestoes <= 0){

            System.out.println("Você terminou a prova.");
            System.out.println("Entregar a prova.");
            
        }

    }

    public static void main(String[] args){
        executar();
    }
}
