package atividade;

import javax.swing.JOptionPane;

public class Atividade02 {
    String aux;
    float v1, v2;
    char op;
    
    try {
        aux = JOptionPane.showInputDialog("Insira o primeiro valor: ");
        v1 = Float.parseFloat(aux);
        aux = JOptionPane.showInputDialog("Insira o segundo valor: ");
        v2 = Float.parseFloat(aux);
        aux = JOptionPane.showInputDialog("Insira a letra respectiva a operação: ");
        op = aux.charAt(op);
        // Dar ToUpper
        switch(op) {
            case 'a':
                JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 + v2 ));
                break;
            case 'b':
                JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 - v2 ));
                break;
            case 'c':
                JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 * v2 ));
                break;
            case 'd':
                JOptionPane.showMessageDialog(null, "Resultado: " + ( v1 / v2 ));
                break;
            default:
                JOptionPane.showMessageDialog(null, "Operação inválida."); break;
        }
    }catch (NumberFormatException erro){ }
    System.exit(0);
}
