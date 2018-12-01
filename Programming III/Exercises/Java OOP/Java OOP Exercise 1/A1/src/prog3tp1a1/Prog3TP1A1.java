
package prog3tp1a1;

import java.util.Scanner;

public class Prog3TP1A1 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        double numUsu;
        double numRob;
        int intentos = 1;
         
        System.out.println("¡Intenta adivinar mi número!");
           
        Robot rob = new Robot();
        numRob = rob.getX();

        System.out.println("Estoy pensando un número entre 0 y 100");
        System.out.print("Adivina: ");
        numUsu = sc.nextDouble();
        
        while (numUsu != numRob) {

            if (numUsu >= numRob) {
                System.out.println("Mi número es menor...");
                System.out.print("Adivina: ");
                numUsu = sc.nextDouble();
                intentos++;
            } else if (numUsu <= numRob) {
                System.out.println("Mi número es mayor...");
                System.out.print("Adivina: ");
                numUsu = sc.nextDouble();
                intentos++;
            } 
            
        }
        
        System.out.println("¡Adivinaste!\nCantidad de intentos: " + intentos);
    }
    
}
