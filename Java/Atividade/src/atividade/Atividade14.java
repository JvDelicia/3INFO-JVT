/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;
import java.awt.GridLayout;
import javax.swing.JFrame;
import javax.swing.DefaultListModel;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

/**
 *
 * @author 3aetim
 */
public class Atividade14 extends JFrame implements ActionListener, ListSelectionListener {
    JLabel l1, l2, l3;
    JTextField t1;   
    JList lista;
    JButton b1, b2;
    DefaultListModel listModel;
    
    public static void main(String[]args){
        JFrame f = new Atividade14();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }

    public Atividade14(){
        setTitle("Desconto");
        setBounds(550,250,700,350);
        getContentPane().setBackground(new Color(0,80,155));
        getContentPane().setLayout(new GridLayout(7,1));
        listModel = new DefaultListModel();
        listModel.addElement("Dinheiro - 5% de Desconto");
        listModel.addElement("Cartão - Acréscimo de 10%");
        listModel.addElement("Cheque - Acréscimo de 5%");
        lista = new JList(listModel);
        lista.addListSelectionListener(this); 
        
        l1 = new JLabel("Escolhe ");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 20));
        
        l2 = new JLabel("Valor :");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 20));
        t1 = new JTextField();
        b1 = new JButton("Calcular");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        
        l3 = new JLabel("");
        l3.setForeground(Color.BLACK);
        l3.setFont(new Font("",Font.BOLD, 20));
        
        add(l2);add(t1); 
        add(lista); 
        add(t1);
        add(b1); add(b2);
        add(l3);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if(e.getSource()==b1){
            String p = (String) lista.getSelectedValue();
            if(p == "Dinheiro - 5% de Desconto"){
                String preco = t1.getText();
                float i = Float.parseFloat(preco);
                float result = (float) ((float) i - (i* 0.05));
                l3.setText("" + result);
            }
            else if(p == "Cartão - Acréscimo de 10%"){
                String preco = t1.getText();
                float i = Float.parseFloat(preco);
                float result = (float) ((float) i + (i* 0.1));
                l3.setText("" + result);
            }
              else if(p == "Cheque - Acréscimo de 5%"){
                String preco = t1.getText();
                float i = Float.parseFloat(preco);
                float result = (float) ((float) i + (i* 0.05));
                l3.setText("" + result);
            }
        }
    }
    public void valueChanged(ListSelectionEvent e){
           
    }

}
