package exemplo;

import javax.swing.JOptionPane;

public class Exemplo03 {
    public static void main(String[] args){
        String aux;
        float n1, n2, media;
        try {
            aux = JOptionPane.showInputDialog("Primeira nota: ");
            n1 = Float.parseFloat(aux);
            aux = JOptionPane.showInputDialog("Segunda nota: ");
            n2 = Float.parseFloat(aux);
            media = ( n1 + n2 ) / 2;
            JOptionPane.showMessageDialog( null, "Média: " + media );
        }catch(NumberFormatException erro) { }
        System.exit(0);
    }
}
