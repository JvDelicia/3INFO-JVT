package atividade;

import java.util.InputMismatchException;
import javax.swing.JOptionPane;

public class Atividade02 {
    public static void main(String[] args) {
        String aux, conv;
        float v1, v2;
        char op = 'g';

        try {
            aux = JOptionPane.showInputDialog("Insira o primeiro valor: ");
            v1 = Float.parseFloat(aux);
            aux = JOptionPane.showInputDialog("Insira o segundo valor: ");
            v2 = Float.parseFloat(aux);
            aux = JOptionPane.showInputDialog("Insira a letra respectiva a operação: ");
            conv = aux.toUpperCase();
            op = conv.charAt(0);
            switch (op) {
                case 'A':
                    JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 + v2 ));
                    break;
                case 'B':
                    JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 - v2 ));
                    break;
                case 'C':
                    JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 * v2 ));
                    break;
                case 'D':
                    JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 / v2 ));
                    break;
                default:
                    JOptionPane.showMessageDialog(null, "Operação inválida."); break;
            }
        }
        catch (InputMismatchException erro) { }
    }
}
