package algoritmo005;

import java.util.Scanner;

public class Main {
    public static void executar() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Pegar os ingredientes");
        System.out.print("Está de roupa branca? (s/n): ");
        String roupaBranca = scanner.nextLine();

        if (roupaBranca.equalsIgnoreCase("s")) {
            System.out.println("Colocar avental");
        }

        System.out.print("Tem batedeira? (s/n): ");
        String temBatedeira = scanner.nextLine();

        if (temBatedeira.equalsIgnoreCase("s")) {
            System.out.println("Bater os ingredientes na batedeira");
        } else {
            System.out.println("Bater os ingredientes à mão");
        }

        System.out.println("Colocar a massa na forma");
        System.out.println("Colocar a forma no forno");
        System.out.println("Aguardar o tempo necessário");
        System.out.println("Retirar o bolo");
    }

    public static void main(String[] args){
        executar();
    }
}