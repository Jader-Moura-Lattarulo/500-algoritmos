package algoritmo004;

import java.util.Scanner;

public class Main {
    public static void executar(){
        Scanner scanner = new Scanner(System.in);

        System.out.println("Vejo a previsão do tempo");
        System.out.print("Está fazendo sol? (s/n): ");
        String fazSol = scanner.nextLine();

        if (fazSol.equalsIgnoreCase("s")){
            System.out.println("Vou à praia");
        } else {
            System.out.println("Vou estudar");
        }

        System.out.println("Almoçar");
        System.out.println("Ver televisão");
        System.out.println("Dormir");
    }

    public static void main (String[] args){
        executar();
    }
}