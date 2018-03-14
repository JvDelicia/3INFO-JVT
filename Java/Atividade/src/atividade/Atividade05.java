package atividade;

import java.text.DecimalFormat;
import java.util.Scanner;

public class Atividade05 {
    public static void main(String[] args){
        Scanner reader = new Scanner(System.in);
        DecimalFormat formater = new DecimalFormat();
        
        try {
            System.out.print("Insira o número de voltas dadas pela roda: ");
            float numv = reader.nextFloat();
            System.out.print("Insira o diâmetro de sua roda em metros: ");
            float diam = reader.nextFloat();
        
            double dist = ((Math.PI * diam) / 2) * numv;
            formater.applyPattern("#,###,##0.00 metros");
            
            System.out.println("A distância percorrida é: " + formater.format(dist));
        } catch(Exception e) {
            System.out.println("Ocorreu um erro: " + e.getMessage());
        }
        System.exit(0);
    }
}