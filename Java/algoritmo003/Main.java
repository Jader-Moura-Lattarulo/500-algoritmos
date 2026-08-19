package algoritmo003;

import java.util.Scanner;

public class Main {
    public static void executar() {

        Scanner scanner = new Scanner(System.in);

        System.out.print("A lâmpada está fora de alcance? (s/n): ");
        String foraDeAlcance = scanner.nextLine();

        if (foraDeAlcance.equalsIgnoreCase("s")) {
            System.out.println("Pegar a escada.");
        }

        System.out.println("Pegar a lâmpada.");

        System.out.print("A lâmpada está quente? (s/n): ");
        String quente = scanner.nextLine();

        if(quente.equalsIgnoreCase("s")) {
            System.out.println("Pegar pano.");
        }

        System.out.println("Tirar lâmpada queimada.");
        System.out.println("Colocar lâmpada boa.");
    }

    public static void main(String[] args) {
        executar();
    }
}