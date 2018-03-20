package atividade;

import java.awt.HeadlessException;
import java.util.Scanner;
import javax.swing.JOptionPane;

public class Atividade04 {
    public static void main(String[] args) {
        String senha = "java", pass;
        boolean aut = false;
        int atmp = 2;
        
        Scanner key = new Scanner(System.in);
        
        try {
            while (aut == false) {
                System.out.println("Insira a senha:");
                pass = key.nextLine();
                if (pass.equals(senha)) {
                    JOptionPane.showMessageDialog(null, "Login realizado com sucesso.");
                    aut = true;
                    atmp = 0;
                }else if (!pass.equals(senha) && atmp <= 3) {
                    JOptionPane.showMessageDialog(null, "Senha errada, tente novamente.");
                    atmp += 1;
                }else {
                    JOptionPane.showMessageDialog(null, "Você errou a senha muitas vezes, cartão cancelado.");
                    System.exit(0);
                }
            }
        }
        catch (HeadlessException erro) {
            System.out.println("Erro na entrada de dados.");
        }
        System.exit(0);
    }
}
