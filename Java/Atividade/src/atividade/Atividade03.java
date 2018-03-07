package atividade;

import java.io.DataInputStream;
import java.io.IOException;

public class Atividade03 {
    public static void main(String[] args) {
        String read;
        int idade;
        
        DataInputStream dado;
        
        try {
            System.out.println("Entre com sua idade: ");
            dado = new DataInputStream(System.in);
            read = dado.readLine();
            idade = Integer.parseInt(read);
            if (idade <= 2 && idade >= 0) {
                System.out.println("Você é um bebê.");
            }else if (idade > 2 && idade <= 11) {
                System.out.println("Você é uma criança.");
            }else if (idade > 11 && idade <= 19) {
                System.out.println("Você é um adolescente.");
            }else if (idade > 19 && idade <= 30) {
                System.out.println("Você é um jovem.");
            }else if (idade > 30 && idade <= 60) {
                System.out.println("Você é um adulto.");
            }else if (idade > 60) {
                System.out.println("Você é um idoso.");
            }else {
                System.out.println("Você nem ta vivo.");
            }
        }catch(IOException erro) {
            System.out.println("Erro na entrada de dados.");
        }catch(NumberFormatException erro) {
            System.out.println("Erro de conversão.");
        }
    }
}
