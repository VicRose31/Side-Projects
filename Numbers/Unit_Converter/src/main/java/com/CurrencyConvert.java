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

        System.out.println("Please select the starting currency;");
        System.out.println("1. " + ARS_FORMAT);
        System.out.println("2. " + CAD_FORMAT);
        System.out.println("3. " + EUR_FORMAT);
        System.out.println("4. " + INR_FORMAT);
        System.out.println("5. " + JPY_FORMAT);
        System.out.println("6. " + KWD_FORMAT);
        System.out.println("7. " + NGN_FORMAT);
        System.out.println("8. " + USD_FORMAT);


        String startingCurrencyID = keyboard.nextLine();
        System.out.println("You have selected " + startingCurrencyID + " as your starting currency." + "\n" +
                "Please select a currency to convert to;");
        System.out.println("1. " + ARS_FORMAT);
        System.out.println("2. " + CAD_FORMAT);
        System.out.println("3. " + EUR_FORMAT);
        System.out.println("4. " + INR_FORMAT);
        System.out.println("5. " + JPY_FORMAT);
        System.out.println("6. " + KWD_FORMAT);
        System.out.println("7. " + NGN_FORMAT);
        System.out.println("8. " + USD_FORMAT);









    }
}
