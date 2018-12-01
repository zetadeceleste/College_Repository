
package prog3tp1A2;

import java.util.Scanner;

public class Prog3TP1A2 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        double num;
        System.out.print("Introduzca número (de tipo double): ");
        num = sc.nextDouble();
        
        calculaMitadNumero(num);
        
        System.out.println("Terminado");
        
    }
    
    public static void calculaMitadNumero(double numero){
        numero = numero/2;
        System.out.println(numero);
        if (numero > 1) {
            calculaMitadNumero(numero);
        }
    }
    
}
