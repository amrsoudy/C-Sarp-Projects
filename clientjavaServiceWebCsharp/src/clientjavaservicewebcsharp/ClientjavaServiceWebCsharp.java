/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package clientjavaservicewebcsharp;

/**
 *
 * @author 1795162
 */
public class ClientjavaServiceWebCsharp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {

            org.tempuri.WebService1 service = new org.tempuri.WebService1();
            org.tempuri.WebService1Soap port = service.getWebService1Soap();
            double a = 15.0d;
            double b = 8.3d;
            double result = port.calculateursoustraction(a, b);
            System.out.println("Resulte de la soustraction  = " + result);
        } catch (Exception ex) {

            ex.printStackTrace();
        }

    }

}
