package algoritmo006;

import java.util.Scanner;

public class Main {
    public static void executar(){
        Scanner scanner = new Scanner(System.in);

        System.out.println("Pegar faca, bacia e batatas");
        System.out.println("Colocar água na bacia.");

        System.out.print("Quantas batatas você tem? ");
        int qtdBatatas = Integer.parseInt(scanner.nextLine());

        int todasBatatas = qtdBatatas;
        int batataDescascando = 1;

        while (qtdBatatas > 0) {
            System.out.println(
                "Descascando a " + batataDescascando + "ª batata."
            );

            qtdBatatas--;
            batataDescascando++;
        }

        batataDescascando--;

        System.out.println(
            "Tadas as " + todasBatatas + " foram descascadas"
        );
    }

    public static void main(String[] args) {
        executar();
    }
}
