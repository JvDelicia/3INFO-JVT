package exemplo;

import java.io.*;

public class Exemplo01 {
    public static void main(String[] args) {
        String s = null;
        double n1 = 0, n2 = 2, media = 0;
        DataInputStream dado;
        
        try {
            System.out.println("Entre com a primeria nota: ");
            dado = new DataInputStream(System.in);
            s = dado.readLine();
            n1 = Double.parseDouble(s);
            System.out.println("Entre com a segunda nota: ");
            dado = new DataInputStream(System.in);
            s = dado.readLine();
            n2 = Double.parseDouble(s);
            media = (n1 + n2) / 2;
            System.out.println("Media: " + media);
        }catch(IOException erro) {
            System.out.println("Erro na entrada de dados.");
        }catch(NumberFormatException erro) {
            System.out.println("Erro de conversão.");
        }
    } 
}