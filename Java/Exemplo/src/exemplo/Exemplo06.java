package exemplo;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

class Exemplo06 extends JFrame implements ActionListener {
    JLabel label1, label2, label3;
    JButton b1, b2, b3, b4, b5;
    JTextField t1, t2, t3;
    
    public static void main(String[] args) {
        JFrame janela = new Exemplo06();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
    Exemplo06() {
        setTitle("Calculator");
        setBounds(300, 50, 350, 90);
        getContentPane().setBackground(new Color(150, 150, 150));
        getContentPane().setLayout(new GridLayout(3, 4));
        label1 = new JLabel("Num 1");
        label1.setForeground(Color.BLACK);
        label1.setFont(new Font("", Font.BOLD, 14));
        label2 = new JLabel("Num 2");
        label2.setForeground(Color.BLACK);
        label2.setFont(new Font("", Font.BOLD, 14));
        label3 = new JLabel("Total");
        label3.setFont(new Font("", Font.BOLD, 14));
        b1 = new JButton("+");
        b1.addActionListener(this);
        b2 = new JButton("-");
        b2.addActionListener(this);
        b3 = new JButton("x");
        b3.addActionListener(this);
        b4 = new JButton("/");
        b4.addActionListener(this);
        b5 = new JButton("Limpar");
        b5.addActionListener(this);
        b5.setBackground(Color.BLACK);
        b5.setForeground(Color.WHITE);
        t1 = new JTextField();
        t2 = new JTextField();
        t3 = new JTextField();
        t3.setEditable(false);
        getContentPane().add(label1);
        getContentPane().add(t1);
        getContentPane().add(b1);
        getContentPane().add(b2);
        getContentPane().add(label2);
        getContentPane().add(t2);
        getContentPane().add(b3);
        getContentPane().add(b4);
        getContentPane().add(label3);
        getContentPane().add(t3);
        getContentPane().add(b5);
    }
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == b5) {
            t1.setText("");
            t2.setText("");
            t3.setText("");
            return;
        }
        double n1 = 0, n2 = 0, res = 0;
        try {
            n1 = Double.parseDouble(t1.getText());
            n2 = Double.parseDouble(t1.getText());
        } catch (NumberFormatException error) {
            t3.setText("Error!" + error);
            return;
        }
        if (e.getSource() == b1) {
            res = n1 + n2;
        } else if (e.getSource() == b2) {
            res = n1 - n2;
        } else if (e.getSource() == b3) {
            res = n1 * n2;
        } else if (e.getSource() == b4) {
            res = n1 / n2;
        }
        t3.setText("" + res);
    }
}
