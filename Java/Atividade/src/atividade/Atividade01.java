package atividade;

import java.util.Scanner;

public class Atividade01 {
    public static void main(String[] args) {
        double val, desc;
        byte cod;
        
        Scanner sc = new Scanner( System.in );
        
        try {
            System.out.println("Digite o valor do produto: ");
            val = sc.nextDouble();
            System.out.println("Digite o código de desconto: ");
            cod = sc.nextByte();
            switch (cod) {
                case 1:
                    desc = val - ( val * 0.05 );
                    System.out.println("O valor do produto com desconto ficou em: " + desc + " reais"); break;
                case 2:
                    desc = val - ( val * 0.1 );
                    System.out.println("O valor do produto com desconto ficou em: " + desc + " reais"); break;
                case 3:
                    desc = val - ( val * 0.2 );
                    System.out.println("O valor do produto com desconto ficou em: " + desc + " reais"); break;
                case 4:
                    desc = val - ( val * 0.5 );
                    System.out.println("O valor do produto com desconto ficou em: " + desc + " reais"); break;
                default:
                    System.out.println("Código de desconto inválido."); break;
            }
            
        }catch (NumberFormatException erro){ }
    }
    
}
