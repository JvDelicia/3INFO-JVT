package atividade;

import java.util.Scanner;

public class Atividade07 {
    public static void main(String[] args) {
        byte resp = 0;
        boolean rep = true;
        float total = 0;
        Scanner reader = new Scanner(System.in);
        while(rep) {
            total += calculo();
            System.out.print("Deseja inserir mais um cômodo? Sim = 1 ou Não = 0: ");
            resp = reader.nextByte();
            if(resp == 0)
                rep = false;
        }
        System.out.print("A área total da moradia é: " + total + "m².");
        System.exit(0);
    }
    public static float calculo() {
        float comp, larg, area;
        String comod;
        Scanner reader = new Scanner(System.in);
        
        System.out.print("Insira o nome do cômodo: ");
        comod = reader.nextLine();
        System.out.print("Insira o comprimento do cômodo, em metros: ");
        comp = reader.nextFloat();
        System.out.print("Insira a largura do cômodo, em emtros: ");
        larg = reader.nextFloat();
        area = comp * larg;
        
        System.out.println("O cômodo " + comod + " possui: " + area + "m²");
        return  area;
    }
}