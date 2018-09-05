/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clientagewebservice;

import java.util.Scanner;

/**
 *
 * @author 1795162
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {

            String DateComplete;
            int year;

            Scanner sc = new Scanner(System.in);
            System.out.println("Svp entre  votre date de naissance ");

            DateComplete = sc.nextLine();
            String[] split = DateComplete.split("-");
            year = Integer.parseInt(split[2]);


            org.tempuri.WebService1 service = new org.tempuri.WebService1();
            org.tempuri.WebService1Soap port = service.getWebService1Soap();

            String s = port.verifier(year);
            System.out.println(s);

        } catch (Exception ex) {
            
            

        }

    }

}
