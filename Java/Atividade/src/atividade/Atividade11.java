
package atividade;
import java.util.Calendar;

public class Atividade11 {
    public static void main(String [] args){
        Calendar dataNsc = Calendar.getInstance();
        dataNsc.set(2017, 06, 05);
        Calendar hoje = Calendar.getInstance();
        System.out.println((((hoje.get(Calendar.YEAR) ) - (dataNsc.get(Calendar.YEAR))) * 365) * 86400000);
    }
}
