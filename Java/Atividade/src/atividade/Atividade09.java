// Eleições 2018
package atividade;

import java.util.Scanner;

public class Atividade09 {
    public static void main(String[] args) {
        byte num, eleito;
        int bolsomito = 0, eymael = 0, lula = 0, manuela = 0;
        int nulo = 0, branco = 0;
        
        do {
            num = votar();
            switch(num) {
                case 17 : bolsomito++; break;
                case 27 : eymael++; break;
                case 13 : lula++; break;
                case 65 : manuela++; break;
                case 1 : nulo++; break;
                case 0 : branco++; break;
                default : break;
            }
        } while (num != 3);

        System.exit(0);
    }
    
    public static byte votar() {
        byte num;
        
        System.out.println("Em quem você vota?");
        System.out.println("+--------------------------+");
        System.out.println("| 17 - BOLSOMITO           |");
        System.out.println("| 27 - Ey Ey Eymael        |");
        System.out.println("| 13 - Lulinha             |");
        System.out.println("| 65 - Manuela D'Comunista |");
        System.out.println("+--------------------------+");
        System.out.println("| 1 - Nulo                 |");
        System.out.println("| 0 - Branco              |");
        System.out.println("+--------------------------+");
        System.out.println("| 3 - Encerrar votação     |");
        System.out.println("+--------------------------+");
        
        num = new Scanner(System.in).nextByte();
        return num;
    }
    
    public static void resultar(int bolsomito, int eymael, int lula, int manuela, int nulo, int branco) {
        int total = bolsomito + eymael + lula + manuela + nulo + branco;
        int valido = total - (nulo + branco);
        
        double mito_porc = (bolsomito / total) * 100;
        double ey_porc = (eymael / total) * 100;
        double lula_porc = (lula / total) * 100;
        double manu_porc = (manuela / total) * 100;
        double nulo_porc = (nulo / total) * 100;
        double bran_porc = (branco / total) * 100;
        
        System.out.println("RESULTADOS");
        System.out.println("Bolsomito: " + bolsomito + "votos.\t" + mito_porc + "%.");
        System.out.println("Eymael: " + eymael + "votos.\t" + ey_porc + "%.");
        System.out.println("Lula: " + lula + "votos.\t" + lula_porc + "%.");
        System.out.println("Manuela: " + manuela + "votos.\t" + manu_porc + "%.");
        System.out.println("Nulos: " + nulo + "votos.\t" + nulo_porc + "%.");
        System.out.println("Brancos: " + branco + "votos.\t" + bran_porc + "%.");
        
        
    }
}
