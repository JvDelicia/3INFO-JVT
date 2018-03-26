package atividade;

public class Atividade08 {
    public static void main(String[] args) {
         fib();
    }
    public static void fib() {
        int i = 0, j = 2;
        int[] nac = new int[15];
        
        nac[0] = 1;
        System.out.print(nac[0] + ", ");
        nac[1] = 1;
        System.out.print(nac[1] + ", ");
        
        while (i < (nac.length - 2)) {
            nac[j] = nac[j - 1] + nac[j - 2];
            if (j == 14) {
                System.out.println(nac[j] + ".");
            } else if (j < 14){
                System.out.print(nac[j] + ", ");
            }
            j++;
            i++;
        }
        System.exit(0);
    }
}