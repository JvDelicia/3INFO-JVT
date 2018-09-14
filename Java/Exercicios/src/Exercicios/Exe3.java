package Exercicios;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JRootPane;
import javax.swing.JTextField;

public class Exe3 extends JFrame implements ActionListener{
    JLabel l1,l2;
    JButton b1,b2;
    JTextField t1;
    public static void main (String[]args){
        JFrame f = new Exe3();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    public Exe3(){
        setTitle("Idade");
        setBounds(600,255,300,200);
        getContentPane().setBackground(new Color(50,100,20));
        getContentPane().setLayout(new GridLayout(5,2));
        l1 = new JLabel("Digite a sua idade:");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 18));
        l2 = new JLabel("Você é ");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 18));
        
        b1 = new JButton("Calcular");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        t1 = new JTextField();
        add(l1);add(t1);
        add(l2);
        add(b1);add(b2);
        
    }
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==b2){
            t1.setText("");
            l2.setText("Você é ");
            t1.requestFocus();
            return;
        }
        int n1 = 0;
        try{
            n1 = Integer.parseInt(t1.getText());
        }catch(NumberFormatException erro){t1.setText("Erro"); }
            if (n1>=0 && n1<=2){
                 l2.setText("Você é "+"Bebê");
             }
             else if (n1>=3 && n1<=11){
                 l2.setText("Você é "+"Criança");
             }
             else if (n1>=12 && n1<=19){
                 l2.setText("Você é "+"Adolescente");
             }
             else if (n1>=20 && n1<=30){
                 l2.setText("Você é "+"Jovem");
             }
             else if (n1>=31 && n1<=60){
                 l2.setText("Você é "+"Adulto");
             }
             else if (n1>=61 && n1<=80){
                 l2.setText("Você é "+"Idoso");
             }
             else if (n1>81){
                 System.out.println("Gretchen"); //Proposital
                 l2.setText("Você é "+"Idoso");
             }
             else{
                 l2.setText("Erro na entrada de dados");
            }
    }   
}