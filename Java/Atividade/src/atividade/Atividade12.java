/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

/**
 *
 * @author 3aetim
 */
public class Atividade12 {
    public static void main(String [] args){
        Scanner sc = new Scanner(System.in);
        String dd, m, a;
        Date d = new Date();

        System.out.println("Digite seu dia de nascimento: ");
        dd = sc.next();
        System.out.println("Digite seu mês de nascimento: ");
        m = sc.next();
        System.out.println("Digite seu ano de nascimento: ");
        a = sc.next();
        SimpleDateFormat sdf =  new SimpleDateFormat("dd-MM-yyyy");
        sdf.setLenient(false);
        try { 
            d = sdf.parse(dd + "-" + m + "-" + a);
            System.out.println("Data válida!");
            
        } catch (ParseException ex) {
            System.out.println ("Data inválida!");
        }
    }
}
