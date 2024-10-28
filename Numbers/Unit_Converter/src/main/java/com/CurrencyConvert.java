package main.java.com;

import main.java.com.model.Currency;

import java.lang.reflect.Array;
import java.math.BigDecimal;
import java.util.*;

public class CurrencyConvert {
    public static void main(String[] args) {
        CurrencyConvert currencyConvert = new CurrencyConvert();
        currencyConvert.run();
    }

    public void run() {

        boolean continueProgram = true;

        Scanner keyboard = new Scanner(System.in);

        final String ARS_STRING = "Argentine Peso";         // +s for >1
        final String CAD_STRING = "Canadian Dollar";        // +s for >1
        final String EUR_STRING = "Euro";                   // +s for >1
        final String INR_STRING = "Indian Rupee";           // +s for >1
        final String JPY_STRING = "Japanese Yen";
        final String KWD_STRING = "Kuwaiti Dinar";          // +s for >1
        final String NGN_STRING = "Nigerian Naira";         // +s for >1
        final String USD_STRING = "United States Dollar";   // +s for >1

//        final String ARS_CODE = "ARS";
//        final String CAD_CODE = "CAD";
//        final String EUR_CODE = "EUR";
//        final String INR_CODE = "INR";
//        final String JPY_CODE = "JPY";
//        final String KWD_CODE = "KWD";
//        final String NGN_CODE = "NGN";
//        final String USD_CODE = "USD";

        final int ARS_INDEX = 0;
        final int CAD_INDEX = 1;
        final int EUR_INDEX = 2;
        final int INR_INDEX = 3;
        final int JPY_INDEX = 4;
        final int KWD_INDEX = 5;
        final int NGN_INDEX = 6;
        final int USD_INDEX = 7;

        //String[] currencyCodes = new String[] {ARS_CODE, CAD_CODE, EUR_CODE, INR_CODE, JPY_CODE, KWD_CODE, NGN_CODE, USD_CODE};
        BigDecimal[] arsConversionRates = new BigDecimal[]
                        {BigDecimal.valueOf(1), BigDecimal.valueOf(0.0014065629),
                        BigDecimal.valueOf(0.00093637289), BigDecimal.valueOf(0.085135107),
                        BigDecimal.valueOf(0.15520362), BigDecimal.valueOf(0.0031052084),
                        BigDecimal.valueOf(1.6638511), BigDecimal.valueOf(0.001012626)};
        BigDecimal[] cadConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(710.96522), BigDecimal.valueOf(1),
                        BigDecimal.valueOf(0.66569677),BigDecimal.valueOf(60.529888),
                        BigDecimal.valueOf(110.34804),BigDecimal.valueOf(0.22078105),
                        BigDecimal.valueOf(1183.0619),BigDecimal.valueOf(0.72002457)};
        BigDecimal[] eurConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(1068.1049), BigDecimal.valueOf(1.502149),
                        BigDecimal.valueOf(1),BigDecimal.valueOf(90.925671),
                        BigDecimal.valueOf(165.76223),BigDecimal.valueOf(0.33166434),
                        BigDecimal.valueOf(1777.0753),BigDecimal.valueOf(1.0815477)};
        BigDecimal[] inrConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(11.746328), BigDecimal.valueOf(0.016520775),
                        BigDecimal.valueOf(0.010997178),BigDecimal.valueOf(1),
                        BigDecimal.valueOf(1.8229791),BigDecimal.valueOf(0.0036475461),
                        BigDecimal.valueOf(19.54537),BigDecimal.valueOf(0.011894755)};
        BigDecimal[] jpyConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(6.443082), BigDecimal.valueOf(0.0090629171),
                        BigDecimal.valueOf(0.0060329857),BigDecimal.valueOf(0.54854633),
                        BigDecimal.valueOf(1),BigDecimal.valueOf(0.002000932),
                        BigDecimal.valueOf(10.721386),BigDecimal.valueOf(0.0065250311)};
        BigDecimal[] kwdConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(3220.0193), BigDecimal.valueOf(4.55289286),
                        BigDecimal.valueOf(3.0150651),BigDecimal.valueOf(247.14328),
                        BigDecimal.valueOf(499.75611),BigDecimal.valueOf(1),
                        BigDecimal.valueOf(5357.8746),BigDecimal.valueOf(3.2609113)};
        BigDecimal[] ngnConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(0.60097173), BigDecimal.valueOf(0.00084512473),
                        BigDecimal.valueOf(0.00056264245),BigDecimal.valueOf(0.051161546),
                        BigDecimal.valueOf(0.093257268),BigDecimal.valueOf(0.00018664117),
                        BigDecimal.valueOf(1),BigDecimal.valueOf(0.00060862032)};
        BigDecimal[] usdConversionRates = new BigDecimal[]
                {BigDecimal.valueOf(987.51263), BigDecimal.valueOf(1.3887205),
                        BigDecimal.valueOf(0.92454635),BigDecimal.valueOf(84.071469),
                        BigDecimal.valueOf(153.25471),BigDecimal.valueOf(0.30665445),
                        BigDecimal.valueOf(1643.2157),BigDecimal.valueOf(1)};

        List<BigDecimal[]> listOfCurrencies = new ArrayList<>();
        listOfCurrencies.add(arsConversionRates);
        listOfCurrencies.add(cadConversionRates);
        listOfCurrencies.add(eurConversionRates);
        listOfCurrencies.add(inrConversionRates);
        listOfCurrencies.add(jpyConversionRates);
        listOfCurrencies.add(kwdConversionRates);
        listOfCurrencies.add(ngnConversionRates);
        listOfCurrencies.add(usdConversionRates);

        if (continueProgram) {


        String startingCurrencyName = "";
        int startingCurrencyIndex = 0;

        while (startingCurrencyName.equals("")) {
            System.out.println("Please select a starting currency;");
            System.out.println("1. " + ARS_STRING);
            System.out.println("2. " + CAD_STRING);
            System.out.println("3. " + EUR_STRING);
            System.out.println("4. " + INR_STRING);
            System.out.println("5. " + JPY_STRING);
            System.out.println("6. " + KWD_STRING);
            System.out.println("7. " + NGN_STRING);
            System.out.println("8. " + USD_STRING);

            int startingCurrencyID = Integer.parseInt(keyboard.nextLine());


            if (startingCurrencyID >= 1 && startingCurrencyID <=8) {
                if (startingCurrencyID == 1) {
                    startingCurrencyName = ARS_STRING;
                } else if (startingCurrencyID == 2) {
                    startingCurrencyName = CAD_STRING;
                    startingCurrencyIndex = CAD_INDEX;
                } else if (startingCurrencyID == 3) {
                    startingCurrencyName = EUR_STRING;
                    startingCurrencyIndex = EUR_INDEX;
                } else if (startingCurrencyID == 4) {
                    startingCurrencyName = INR_STRING;
                    startingCurrencyIndex = INR_INDEX;
                } else if (startingCurrencyID == 5) {
                    startingCurrencyName = JPY_STRING;
                    startingCurrencyIndex = JPY_INDEX;
                } else if (startingCurrencyID == 6) {
                    startingCurrencyName = KWD_STRING;
                    startingCurrencyIndex = KWD_INDEX;
                } else if (startingCurrencyID == 7) {
                    startingCurrencyName = NGN_STRING;
                    startingCurrencyIndex = NGN_INDEX;
                } else {
                    startingCurrencyName = USD_STRING;
                    startingCurrencyIndex = USD_INDEX;
                }
            } else {
                System.out.println("Please type a number between 1 and 8 to select a starting currency.");
            }
        }


        System.out.println("You have selected " + startingCurrencyName + " as your starting currency." + "\n");

        String targetCurrencyName = "";
        int targetCurrencyIndex = 0;

        while (targetCurrencyName.equals("")) {
            System.out.println("Please select a currency to convert to;");
            System.out.println("1. " + ARS_STRING);
            System.out.println("2. " + CAD_STRING);
            System.out.println("3. " + EUR_STRING);
            System.out.println("4. " + INR_STRING);
            System.out.println("5. " + JPY_STRING);
            System.out.println("6. " + KWD_STRING);
            System.out.println("7. " + NGN_STRING);
            System.out.println("8. " + USD_STRING);

            int targetCurrencyID = Integer.parseInt(keyboard.nextLine());
            if (targetCurrencyID >= 1 && targetCurrencyID <=8) {
                if (targetCurrencyID == 1) {
                    targetCurrencyName = ARS_STRING;
                } else if (targetCurrencyID == 2) {
                    targetCurrencyName = CAD_STRING;
                    targetCurrencyIndex = CAD_INDEX;
                } else if (targetCurrencyID == 3) {
                    targetCurrencyName = EUR_STRING;
                    targetCurrencyIndex = EUR_INDEX;
                } else if (targetCurrencyID == 4) {
                    targetCurrencyName = INR_STRING;
                    targetCurrencyIndex = INR_INDEX;
                } else if (targetCurrencyID == 5) {
                    targetCurrencyName = JPY_STRING;
                    targetCurrencyIndex = JPY_INDEX;
                } else if (targetCurrencyID == 6) {
                    targetCurrencyName = KWD_STRING;
                    targetCurrencyIndex = KWD_INDEX;
                } else if (targetCurrencyID == 7) {
                    targetCurrencyName = NGN_STRING;
                    targetCurrencyIndex = NGN_INDEX;
                } else {
                    targetCurrencyName = USD_STRING;
                    targetCurrencyIndex = USD_INDEX;
                }
            } else {
                System.out.println("Please type a number between 1 and 8 to select a target currency." + "\n");
            }
        }

        System.out.println("You have selected " + targetCurrencyName + " as your target currency." + "\n");

        System.out.println("Please enter the amount of money in " + startingCurrencyName + " format to convert to " +
                targetCurrencyName + " format.");

        BigDecimal[] conversionRateArray = listOfCurrencies.get(startingCurrencyIndex);             //get correct conversion rate array from the list of currencies
        BigDecimal conversionRate = conversionRateArray[targetCurrencyIndex];                       //get correct rate from the array of conversion rates
        BigDecimal amountToConvert = BigDecimal.valueOf(Double.parseDouble(keyboard.nextLine()));   //store user input as a BigDecimal
        BigDecimal convertedAmount = conversionRate.multiply(amountToConvert);                      //multiply rate by amount

        System.out.println(amountToConvert + " " + startingCurrencyName + " = " + "\n" +
                            convertedAmount + " " + targetCurrencyName + "\n");
        System.out.println("Would you like to convert another value? Type 'Y' for yes or 'N' for no.)" + "\n");
        String userDecision = keyboard.nextLine();

        if (userDecision.equalsIgnoreCase("n")) {
            continueProgram = false;
        }


        } else {
            System.exit(0);
        }















    }
}
