/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade;

import java.util.Scanner;

/**
 *
 * @author 3aetim
 */
public class Atividade13 {
    abstract class Veiculo {
        String modelo, marca, placa, cor, anof;
        public void setModelo(String modelo){
            this.modelo = modelo;
        }
        public String getModelo(){ return (modelo); }
        
        public void setMarca(String marca){
            this.marca = marca;
        }
        public String getMarca(){ return (marca); }
        
        public void setPlaca(String placa){
            this.placa = placa;
        }
        public String getPlaca(){ return (placa); }
        
        public void setCor(String cor){
            this.cor = cor;
        }
        public String getCor(){ return (cor); }
        
        public void setAnof(String anof){
            this.anof = anof;
        }
        public String getAnof(){ return (anof); }
    }
    
    class Carro extends Veiculo{
        String capportamalas, qportas;
        public void setCapportamalas(String capportamalas){
            this.capportamalas = capportamalas;
        }
        public String getCapportamalas(){ return (capportamalas); }
        
        public void setQportas(String qportas){
            this.qportas = qportas;
        }
        public String getQportas(){ return (qportas); }
    }
    
    class Caminhao extends Veiculo{
        String quanteixo, tipocabine;
        public void setQuanteixo(String quanteixo){
            this.quanteixo = quanteixo;
        }
        public String getQuanteixo(){ return (quanteixo); }
        
        public void setTipocabine(String tipocabine){
            this.tipocabine = tipocabine;
        }
        public String getTipocabine(){ return (tipocabine); }
    }
    
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        int r;
        Carro car;
        Caminhao cam;
        do{
        System.out.println("Digite o item que deseja acessar:");
        System.out.println("1- Cadastrar Carros\n2- Cadastrar Caminhão\n3- Listar Carros\n4- Listar Caminhões\n5- Listar Carro pela Cor\n6- Listar Caminhão pela Marca\n0- Sair");
        r = sc.nextInt();
        }while(r <= 6 && r >= 0);
        switch(r){
            case 1 : car = cadCar(); break;
            case 2 : cam = cadCam(); break;
            case 3 : lstCar(); break;
            case 4 : lstCam(); break;
            case 5 : lstCarCor(); break;
            case 6 : lstCamMarc(); break;
            default: System.exit(0);; break;
        }
    }
    
    public static Carro cadCar(){ return null; }
    public static Caminhao cadCam(){return null; }
    public static void lstCar(){}
    public static void lstCam(){}
    public static void lstCarCor(){}
    public static void lstCamMarc(){}
}
