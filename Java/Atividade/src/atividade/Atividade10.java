package atividade;
import java.util.Calendar;
import java.util.Date; 

public class Atividade10 {
    public static void main(String [] args){
        Date d = new Date();
        Calendar c = Calendar.getInstance(); 
        c.setTime(d);
        int dia = c.get(c.DAY_OF_WEEK);
        switch(dia){
          case Calendar.SUNDAY : System.out.println("Domingo é dia de comprar ar!!! Ainda mais com esse desconto de 100%!!!"); break;
          case Calendar.MONDAY : System.out.println("Segunda é dia de viver!!! Ainda mais com esse desconto de 30%!!!"); break;
          case Calendar.TUESDAY : System.out.println("Terça é dia de dar um beijo no leleo!!! Ainda mais com esse desconto de 30%!!!"); break;
          case Calendar.WEDNESDAY : System.out.println("Quarta é dia de bater no gaymer!!! Ainda mais com esse desconto de 200%!!!"); break;
          case Calendar.THURSDAY : System.out.println("Quinta é dia de pastel!!! Ainda mais com esse desconto de 80%!!!"); break;
          case Calendar.FRIDAY : System.out.println("Sexta é dia de maldade!!! Ainda mais com esse desconto de 20%!!!"); break;
          case Calendar.SATURDAY : System.out.println("Sábado é dia de comer b_ _ _ta!!! Ainda mais com esse desconto de 20%!!!"); break;
        }
    }
}
