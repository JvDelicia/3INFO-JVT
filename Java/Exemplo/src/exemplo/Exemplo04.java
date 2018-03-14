package exemplo;

import java.text.DecimalFormat;

public class Exemplo04 {
    public static void main(String[] args){
        DecimalFormat df = new DecimalFormat();
        short idade = 38;
        df.applyPattern("000");
        System.out.println(df.format(idade));
        
        int qnd = 9950;
        df.applyPattern("#0.000");
        System.out.println(df.format(qnd));
        
        long est = 198564;
        df.applyPattern("#,##0.000");
        System.out.println(df.format(est));
        
        double peso = 70.25;
        df.applyPattern("#0.00");
        System.out.println(df.format(peso));
        
        String real = "2583.75";
        df.applyPattern("R$ #,##0.00");
        System.out.println(df.format(Double.parseDouble(real)));
    }
}
