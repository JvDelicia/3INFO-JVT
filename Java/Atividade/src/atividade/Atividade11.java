
package atividade;
import java.util.Calendar;
import java.util.Scanner;

public class Atividade11 {
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        int dd, m, a;
        System.out.println("Digite seu dia de nascimento: ");
        dd = sc.nextInt();
        System.out.println("Digite seu mês de nascimento: ");
        m = sc.nextInt();
        System.out.println("Digite seu ano de nascimento: ");
        a = sc.nextInt();
        Calendar hoje = Calendar.getInstance();
        Calendar dataNsc = Calendar.getInstance();
        dataNsc.set(a, m, dd);
        long d = ( hoje.get(Calendar.YEAR) - dataNsc.get(Calendar.YEAR));
        System.out.println((d * 365) * 86400000);
    }
}
