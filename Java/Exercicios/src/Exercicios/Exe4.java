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

public class Exe4 extends JFrame implements ActionListener{
    JLabel l1,l2;
    JButton b1,b2;
    JTextField t1;
    int i=0;
    public static void main (String[]args){
        JFrame f = new Exe4();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    public Exe4(){
        setTitle("Senha do cartão");
        setBounds(600,300,300,250);
        getContentPane().setBackground(new Color(0,120,255));
        getContentPane().setLayout(new GridLayout(5,2));
        l1 = new JLabel("Digite a senha do cartão:");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 14));
        l2 = new JLabel("");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 32));
        
        b1 = new JButton("Entrar");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        t1 = new JTextField();
        add(l1);add(t1);
        add(b1);add(b2);
        add(l2);
    }
    public void actionPerformed(ActionEvent e)
    {
        if(e.getSource()==b2){
            t1.setText("");
            l2.setText("");
            t1.requestFocus();
            return;
        }
        
        String senha="";
        
        try
        {
            senha = t1.getText();
        }
        catch(NumberFormatException erro){l2.setText("Erro"); }
        try
        {
            if(senha.equals("java")) {
                l2.setText("Senha Válida");
            }
            else if(senha !="java"){
                l2.setText("Senha inválida: " +(i+1)+" tentativa(s)");   
                i++;
            }

            if(i>2)
            {
                l2.setText("Cartão bloqueado");
            }
        }
        catch(NumberFormatException erro){}
    }
}   
