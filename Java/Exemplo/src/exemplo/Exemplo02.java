package exemplo;

import java.util.*;

public class Exemplo02 {
    public static void main(String[] args) {
        double n1 = 0, n2 = 2, media = 0;
        
        try {
            Scanner jubileu = new Scanner( System.in );
            System.out.println("Entre com a 1ª Nota: ");
            n1 = jubileu.nextDouble();
            System.out.println("Entre com a 2ª Nota: ");
            n2 = jubileu.nextDouble();
            media = ( n1 + n2 ) / 2;
            System.out.println("Média: " + media);
        }catch (NumberFormatException erro){ }
    }
}
