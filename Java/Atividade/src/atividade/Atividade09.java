// Eleições 2018
package atividade;

import java.text.DecimalFormat;
import java.util.Scanner;

public class Atividade09 {
    public static void main(String[] args) {
        byte num, eleito;
        double bolsomito = 0, eymael = 0, lula = 0, manuela = 0;
        double nulo = 0, branco = 0;
        
        do {
            num = votar();
            switch(num) {
                case 17 : bolsomito++; break;
                case 27 : eymael++; break;
                case 13 : lula++; break;
                case 65 : manuela++; break;
                case 0 : branco++; break;
                default : System.out.println("Candidato inválido, voto nulo!"); nulo++; break;
            }
        } while (num != 3);
        resultar(bolsomito, eymael, lula, manuela, nulo, branco);
        System.exit(0);
    }
    
    public static byte votar() {
        byte num;
        
        System.out.println("+--------------------------+");
        System.out.println("| 17 - BOLSOMITO           |");
        System.out.println("| 27 - Ey Ey Eymael        |");
        System.out.println("| 13 - Lulinha             |");
        System.out.println("| 65 - Manuela D'Comunista |");
        System.out.println("+--------------------------+");
        System.out.println("| 0 - Branco               |");
        System.out.println("+--------------------------+");
        System.out.println("| 3 - Encerrar votação     |");
        System.out.println("+--------------------------+");
        System.out.print("Digite seu voto: ");
        
        num = new Scanner(System.in).nextByte();
        return num;
    }
    
    public static void resultar(double bolsomito, double eymael, double lula, double manuela, double nulo, double branco) {
        double total = bolsomito + eymael + lula + manuela + nulo + branco;
        double valido = total - (nulo + branco);
        
        DecimalFormat df = new DecimalFormat();
        
        double mito_porc = (bolsomito / total) * 100;
        double ey_porc = (eymael / total) * 100;
        double lula_porc = (lula / total) * 100;
        double manu_porc = (manuela / total) * 100;
        double nulo_porc = (nulo / total) * 100;
        double bran_porc = (branco / total) * 100;
        
        System.out.println("RESULTADOS");
        System.out.println("Bolsomito: \t\t" + bolsomito + " votos.\t\t" + mito_porc + "%.");
        System.out.println("Eymael: \t\t" + eymael + " votos.\t\t" + ey_porc + "%.");
        System.out.println("Lula: \t\t" + lula + " votos.\t\t" + lula_porc + "%.");
        System.out.println("Manuela: \t\t" + manuela + " votos.\t\t" + manu_porc + "%.");
        System.out.println("Nulos: \t\t" + nulo + " votos.\t\t" + nulo_porc + "%.");
        System.out.println("Brancos: \t\t" + branco + " votos.\t\t" + bran_porc + "%.");
        
        
    }
}
