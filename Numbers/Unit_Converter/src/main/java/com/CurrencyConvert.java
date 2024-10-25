package main.java.com;

import main.java.com.model.Currency;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CurrencyConvert {
    public static void main(String[] args) {
        CurrencyConvert currencyConvert = new CurrencyConvert();
        currencyConvert.run();
    }

    public void run() {

        Scanner keyboard = new Scanner(System.in);

        List<String> currencies = new ArrayList<>();

        final String ARS_FORMAT = "Argentine Peso";
        final String CAD_FORMAT = "Canadian Dollar";
        final String EUR_FORMAT = "Euro";
        final String INR_FORMAT = "Indian Rupee";
        final String JPY_FORMAT = "Japanese Yen";
        final String KWD_FORMAT = "Kuwaiti Dinar";
        final String NGN_FORMAT = "Nigerian Naira";
        final String USD_FORMAT = "United States Dollar";

        String startingCurrencyName = "";

        while (startingCurrencyName.equals("")) {
            System.out.println("Please select a starting currency;");
            System.out.println("1. " + ARS_FORMAT);
            System.out.println("2. " + CAD_FORMAT);
            System.out.println("3. " + EUR_FORMAT);
            System.out.println("4. " + INR_FORMAT);
            System.out.println("5. " + JPY_FORMAT);
            System.out.println("6. " + KWD_FORMAT);
            System.out.println("7. " + NGN_FORMAT);
            System.out.println("8. " + USD_FORMAT);

            int startingCurrencyID = Integer.parseInt(keyboard.nextLine());


            if (startingCurrencyID >= 1 && startingCurrencyID <=8) {
                if (startingCurrencyID == 1) {
                    startingCurrencyName = ARS_FORMAT;
                } else if (startingCurrencyID == 2) {
                    startingCurrencyName = CAD_FORMAT;
                } else if (startingCurrencyID == 3) {
                    startingCurrencyName = EUR_FORMAT;
                } else if (startingCurrencyID == 4) {
                    startingCurrencyName = INR_FORMAT;
                } else if (startingCurrencyID == 5) {
                    startingCurrencyName = JPY_FORMAT;
                } else if (startingCurrencyID == 6) {
                    startingCurrencyName = KWD_FORMAT;
                } else if (startingCurrencyID == 7) {
                    startingCurrencyName = NGN_FORMAT;
                } else {
                    startingCurrencyName = USD_FORMAT;
                }
            } else {
                System.out.println("Please type a number between 1 and 8 to select a starting currency.");
            }
        }




        System.out.println("You have selected " + startingCurrencyName + " as your starting currency." + "\n");

        String targetCurrencyName = "";

        while (targetCurrencyName.equals("")) {
            System.out.println("Please select a currency to convert to;");
            System.out.println("1. " + ARS_FORMAT);
            System.out.println("2. " + CAD_FORMAT);
            System.out.println("3. " + EUR_FORMAT);
            System.out.println("4. " + INR_FORMAT);
            System.out.println("5. " + JPY_FORMAT);
            System.out.println("6. " + KWD_FORMAT);
            System.out.println("7. " + NGN_FORMAT);
            System.out.println("8. " + USD_FORMAT);

            int targetCurrencyID = Integer.parseInt(keyboard.nextLine());
            if (targetCurrencyID >= 1 && targetCurrencyID <=8) {
                if (targetCurrencyID == 1) {
                    targetCurrencyName = ARS_FORMAT;
                } else if (targetCurrencyID == 2) {
                    targetCurrencyName = CAD_FORMAT;
                } else if (targetCurrencyID == 3) {
                    targetCurrencyName = EUR_FORMAT;
                } else if (targetCurrencyID == 4) {
                    targetCurrencyName = INR_FORMAT;
                } else if (targetCurrencyID == 5) {
                    targetCurrencyName = JPY_FORMAT;
                } else if (targetCurrencyID == 6) {
                    targetCurrencyName = KWD_FORMAT;
                } else if (targetCurrencyID == 7) {
                    targetCurrencyName = NGN_FORMAT;
                } else {
                    targetCurrencyName = USD_FORMAT;
                }
            } else {
                System.out.println("Please type a number between 1 and 8 to select a target currency." + "\n");
            }
        }

        System.out.println("You have selected " + targetCurrencyName + " as your target currency." + "\n");

        System.out.println("Please enter the amount of money in " + startingCurrencyName + " format to convert to " +
                targetCurrencyName + " format.");

        













    }
}
