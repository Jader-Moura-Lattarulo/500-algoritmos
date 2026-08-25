package algoritmo008;

import java.util.Scanner;

public class Main {
    public static void executar(){
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a palavra escolhida: ");
        String palavra = scanner.nextLine().toLowerCase();

        int lacunasVazias = palavra.length();
        int partesCorpo = 0;
        int maximoPartesCorpo = 6;

        System.out.println();
        System.out.println("Montar o diagrama do jogo.");

        while (lacunasVazias > 0 && partesCorpo < maximoPartesCorpo){

            System.out.print("Digite uma letra: ");
            String letra = scanner.nextLine().toLowerCase();

            if (palavra.contains(letra)) {
                System.out.println("Acertou uma letra!");
                lacunasVazias--;
            } else {
                System.out.println("Errou!");
                partesCorpo++;
            }
            
            System.out.println(
                "Lacunas vazias: %d".formatted(lacunasVazias)
            );

            System.out.println(
                "Partes do corpo: %d/%d".formatted(
                    partesCorpo,
                    maximoPartesCorpo
                )
            );

            System.out.println();
        }

        if (lacunasVazias == 0) {
            System.out.println("Parabéns! Você acertou a palavra.");
        } else {
            System.out.println("Fim de jogo! O corpo foi completado na forca.");
        }
    }

    public static void main(String[] args){
        executar();
    }
}