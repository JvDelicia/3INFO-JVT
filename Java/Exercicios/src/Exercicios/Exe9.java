package Exercicios;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JRootPane;
import javax.swing.JTextField;
import javax.swing.SwingConstants;

public class Exe9 extends JFrame implements ActionListener
{
    JLabel l1_1,l1_2,l1_3,l2_1,l2_2,l2_3;
    JButton b1,b2,b3, voto1,voto2,voto3,voto4,voto5,voto6;
    int c1 = 0, c2 = 0, c3 = 0, c4 = 0, vb = 0, vn = 0, ne = 0;
    int i=0;
    
    public static void main (String[]args)
    {
        JFrame f = new Exe9();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    
    public Exe9()
    {
        setTitle("Eleição");
        setBounds(550,250,700,350);
        getContentPane().setBackground(new Color(0,80,155));
        getContentPane().setLayout(new GridLayout(6,3));
        l1_1 = new JLabel("");
        l1_1.setForeground(Color.BLACK);
        l1_1.setFont(new Font("",Font.BOLD, 20));
        l1_2 = new JLabel("       Eleições 2018");
        l1_2.setForeground(Color.BLACK);
        l1_2.setFont(new Font("",Font.BOLD, 20));
        l1_3 = new JLabel("");
        l1_3.setForeground(Color.BLACK);
        l1_3.setFont(new Font("",Font.BOLD, 20));
        
        l2_1 = new JLabel("");
        l2_1.setForeground(Color.BLACK);
        l2_1.setFont(new Font("",Font.BOLD, 14));
        l2_2 = new JLabel("");
        l2_2.setForeground(Color.BLACK);
        l2_2.setFont(new Font("",Font.BOLD, 14));
        l2_3 = new JLabel("");
        l2_3.setForeground(Color.BLACK);
        l2_3.setFont(new Font("",Font.BOLD, 14));
        
        b1 = new JButton("Votar");
        b1.addActionListener(this);
        b2 = new JButton("Contar votos");
        b2.addActionListener(this);
        b3 = new JButton("Sair");
        b3.addActionListener(this);
        voto1 = new JButton("Leleo");
        voto1.addActionListener(this);
        voto1.setVisible(false);
        voto2 = new JButton("JV");
        voto2.addActionListener(this);
        voto2.setVisible(false);
        voto3 = new JButton("Lulinha (não mais)");
        voto3.addActionListener(this);
        voto3.setVisible(false);
        voto4 = new JButton("Ph");
        voto4.addActionListener(this);
        voto4.setVisible(false);
        voto5 = new JButton("Voto em branco");
        voto5.addActionListener(this);
        voto5.setVisible(false);
        voto6 = new JButton("Voto nulo");
        voto6.addActionListener(this);
        voto6.setVisible(false);
        
        add(l1_1);add(l1_2);add(l1_3);
        add(b1);add(b2);add(b3);
        add(l2_1);add(l2_2);add(l2_3);
        add(voto1);add(voto2);add(voto3);
        add(voto4);add(voto5);add(voto6);

    }
    public void actionPerformed(ActionEvent e)
    {
        try
        {
            if(e.getSource() == b1)
            {
                voto1.setVisible(true);
                voto2.setVisible(true);
                voto3.setVisible(true);
                voto4.setVisible(true);
                voto5.setVisible(true);
                voto6.setVisible(true);
            }
            if(e.getSource() == voto1)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                c1++;
                ne++;
            }
            if(e.getSource() == voto2)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                c2++;
                ne++;
            }
            if(e.getSource() == voto3)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                c3++;
                ne++;
            }
            if(e.getSource() == voto4)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                c4++;
                ne++;
            }
            if(e.getSource() == voto5)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                vb++;
                ne++;
            }
            if(e.getSource() == voto6)
            {
                JOptionPane.showMessageDialog(rootPane, "Voto realizado com sucesso!");
                vn++;
                ne++;
            }
            if(e.getSource() == b2)
            {
                iniciarContagem(c1, c2, c3, c4, vb, vn, ne);
            }
            if(e.getSource() == b3)
            {
                System.exit(0);
            }
        }
        catch (NumberFormatException erro){}
    }
    public void iniciarContagem(int c1, int c2, int c3, int c4, int vb, int vn, int ne)
    {
        String vencedor = "";
        double max;
        max = Math.max(c1, Math.max(c2, Math.max(c3, Math.max(c4, Math.max(vb, vn)))));
        if(max == c1){
            vencedor = "BOLSOMITO";
        }
        else if (max == c2){
            vencedor = "Ey Ey Eymael";
        }
        else if (max == c3){
            vencedor = "Lulinha (não mais)";
        }
        else if (max == c4){
            vencedor = "Manuela D'Comunista";
        }
        else if (max == vb){
            vencedor = "Sem vencedor, votos em branco";
        }
        else if (max == vn){
            vencedor = "Sem vencedor, votação anulada";
        }
        JOptionPane.showMessageDialog(rootPane,      
                "Porcentagem de votos"
               +"\nBOLSOMITO: "+(c1*100)/ne+"%"
               +"\nEy Ey Eymael: "+(c2*100)/ne+"%"
               +"\nLulinha (não mais): "+(c3*100)/ne+"%"
               +"\nManuela D'Comunista: "+(c4*100)/ne+"%"
               +"\nVotos em branco: "+(vb*100)/ne+"%"
               +"\nVotos nulos: "+(vn*100)/ne+"%"
               +"\nVotos válidos: "+(ne-vb-vn)
               +"\nNúmero de Eleitores: "+ne+" eleitores"
               +"\n\nVENCEDOR DA ELEIÇÃO: "+vencedor+"\n"
        );
       System.exit(0);
    }        
}