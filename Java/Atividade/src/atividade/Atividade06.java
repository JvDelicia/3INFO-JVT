package atividade;

import java.util.Scanner;

public class Atividade06 {
    public static void main(String[] args) {
        double num = 0.0, media, som, rest;
       
        double[] val = new double[4];
        
        Scanner sc = new Scanner(System.in);
        try {
            for (int i = 0; i < val.length; i++) {
                System.out.println("Digite o " + (i+1) + "º valor: ");
                val[i] = sc.nextDouble();
            }

            for (double v : val) {
                num += v;
            }

            som = num;
            media = num / val.length;
            System.out.println("A média é: " + media);
            System.out.println("O somatório entre eles é: " + som);

            for (int j = 0; j < val.length; j++) {
                rest = som % val[j];
                System.out.println("O resto da divisão com o " + (j+1) + "º número é: " + rest);
            }
        } catch (Exception e) {
            System.out.println("Ocorreu um erro: " + e.getMessage());
        }
    }
}
