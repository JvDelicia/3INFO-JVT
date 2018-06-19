/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author 3aetim
 */
public class Atividade13 {
    abstract class Veiculo {
        public String Modelo;
        public String Marca;
        public String Placa;
        public String Cor;
        public String Anof;
    }
    
    static class Carro extends Veiculo{
        Scanner sc = new Scanner(System.in);
        public String Capportamalas;
        public String Qportas;
        
        public Carro cad(){
            Carro c = new Carro();
            System.out.println("Digite o modelo:");
            c.Modelo = sc.next();
            System.out.println("Digite a marca:");
            c.Marca = sc.next();
            System.out.println("Digite a placa:");
            c.Placa = sc.next();
            System.out.println("Digite a cor:");
            c.Cor = sc.next();
            System.out.println("Digite o ano de fabricação:");
            c.Anof = sc.next();
            System.out.println("Digite a capacidade do porta malas:");
            c.Capportamalas = sc.next();
            System.out.println("Digite a quantidade de portas:");
            c.Qportas = sc.next();
            return c;
        }
    }
    
    static class Caminhao extends Veiculo{ 
        public String Quanteixo;
        public String Tipocabine;
        Scanner sc = new Scanner(System.in);
        
        public Caminhao cad(){
            Caminhao c = new Caminhao();
            System.out.println("Digite o modelo:");
            c.Modelo = sc.next();
            System.out.println("Digite a marca:");
            c.Marca = sc.next();
            System.out.println("Digite a placa:");
            c.Placa = sc.next();
            System.out.println("Digite a cor:");
            c.Cor = sc.next();
            System.out.println("Digite o ano de fabricação:");
            c.Anof = sc.next();
            System.out.println("Digite a quantidade de eixos");
            c.Quanteixo = sc.next();
            System.out.println("Digite o tipo da cabine:");
            c.Tipocabine = sc.next();
            return c;
        }
    }
    
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        int r;
        Caminhao cam = new Caminhao();
        Carro car = new Carro();
        ArrayList<Carro> lstCar = new ArrayList<Carro>();
        ArrayList<Caminhao> lstCam = new ArrayList<Caminhao>();
        while(true){
            System.out.println("Digite o item que deseja acessar:");
            System.out.println("1- Cadastrar Carros\n2- Cadastrar Caminhão\n3- Listar Carros\n4- Listar Caminhões\n5- Listar Carro pela Cor\n6- Listar Caminhão pela Marca\n0- Sair");
            r = sc.nextInt();
            switch(r){
                case 1 : lstCar.add(car.cad()); break;
                case 2 : lstCam.add(cam.cad()); break;
                case 3 : listarCar(lstCar); break;
                case 4 : listarCam(lstCam); break;
                case 5 : lstCarCor(lstCar); break;
                case 6 : lstCamMarc(lstCam); break;
                case 0: System.exit(0);; break;
                default: System.exit(0);; break;
            }        
        }
    }
    
    public static void listarCar(ArrayList<Carro> carros){
        for (Carro c: carros) {
            System.out.println("Modelo: " + c.Modelo);
            System.out.println("Marca: " + c.Marca);
            System.out.println("Placa: " + c.Placa);
            System.out.println("Cor: " + c.Cor);
            System.out.println("Ano de Fabricação: " + c.Anof);
            System.out.println("Capacidade do porta malas: " + c.Capportamalas);
            System.out.println("Quantidade de Portas: " + c.Qportas);
        }
    }
    public static void listarCam(ArrayList<Caminhao> caminhao){
        for (Caminhao c: caminhao) {
            System.out.println("Modelo: " + c.Modelo);
            System.out.println("Marca: " + c.Marca);
            System.out.println("Placa: " + c.Placa);
            System.out.println("Cor: " + c.Cor);
            System.out.println("Ano de Fabricação: " + c.Anof);
            System.out.println("Tipo de cabine: " + c.Tipocabine);
            System.out.println("Quantidade de eixos: " + c.Quanteixo);
        }
    }
    public static void lstCarCor(ArrayList<Carro> carros){
        System.out.println("Digite a cor do carro: ");
        for (Carro c: carros) {
            if (c.Cor.equals(new Scanner(System.in).next())) {
                System.out.println("Modelo: " + c.Modelo);
                System.out.println("Marca: " + c.Marca);
                System.out.println("Placa: " + c.Placa);
                System.out.println("Cor: " + c.Cor);
                System.out.println("Ano de Fabricação: " + c.Anof);
                System.out.println("Capacidade do porta malas: " + c.Capportamalas);
                System.out.println("Quantidade de Portas: " + c.Qportas);
            }
        }
    }
    public static void lstCamMarc(ArrayList<Caminhao> caminhao){
        System.out.println("Digite a marca do caminhão: ");
        for (Caminhao c: caminhao) {
            if (c.Marca.equals(new Scanner(System.in).next())) {
                System.out.println("Modelo: " + c.Modelo);
                System.out.println("Marca: " + c.Marca);
                System.out.println("Placa: " + c.Placa);
                System.out.println("Cor: " + c.Cor);
                System.out.println("Ano de Fabricação: " + c.Anof);
                System.out.println("Tipo de cabine: " + c.Tipocabine);
                System.out.println("Quantidade de eixos: " + c.Quanteixo);
            }
        }
    }
}
