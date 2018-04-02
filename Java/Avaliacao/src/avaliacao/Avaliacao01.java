package avaliacao;

import java.io.DataInputStream;
import java.io.IOException;


public class Avaliacao01 {
    public static void main(String[] args) throws IOException {
        int cod, vag, masc, fem;
        byte arr = 0, op = 0;
        boolean rep = true, tru = true;
        
        Curso[] cursos = new Curso[200];
        DataInputStream data = new DataInputStream(System.in);
        
        while(rep) {
            try {
                System.out.print("Insira o código do curso: ");
                cod = Integer.parseInt(data.readLine());
                System.out.print("Insira o número de vagas totais: ");
                vag = Integer.parseInt(data.readLine());
                System.out.print("Insira o número de candidatos homens: ");
                masc = Integer.parseInt(data.readLine());
                System.out.print("Insira o número de candidatos mulheres: ");
                fem = Integer.parseInt(data.readLine());
                cursos[arr] = new Curso(cod, vag, masc, fem);

            } catch (Exception e) {
                System.out.println(e.getMessage());
            }
            
            try {
                while (tru) {
                    System.out.println("Deseja inserir mais um curso?");
                    System.out.println("Sim = 1 ou Não = 0");
                    op = Byte.parseByte(data.readLine());

                    if ( op == 1) {
                        arr++;
                        tru = false;
                    } else if (op == 0) {
                        rep = false;
                        tru = false;
                    } else {
                        System.out.println("Opção inválida!");
                    }
                }
            } catch (Exception e) {
                System.out.println(e.getMessage());
            }
        }
        
        int candVaga, sumC, vaga = 0, code = 0, candT = 0;
        double porcMasc, porcFem;
        
        try {
            for (Curso curso : cursos) {
                sumC = curso.getFem() + curso.getMasc();
                candVaga = sumC / curso.getVag();
                System.out.println("Para o curso de " + curso.getCod() + ", temos que: ");
                System.out.println("O número de candidatos por vaga é: " + candVaga + ".");

                porcMasc = (curso.getMasc() / sumC) * 100;
                porcFem = (curso.getFem() / sumC) * 100;
                System.out.println("A porcentagem de homens é: " + porcMasc + "%.");
                System.out.println("A porcentagem de mulheres é: " + porcFem + "%.");

                if ( candVaga > vaga ) {
                    vaga = candVaga;
                    code = curso.getCod();
                }

                candT = sumC + candT;
            }
            System.out.println("O curso com maior candidatos por vaga é: " + code + " com um total de " + vaga + " candidatos.");
            System.out.println("O total geral de candidatos é: " + candT + ".");
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        System.exit(0);
    }
}