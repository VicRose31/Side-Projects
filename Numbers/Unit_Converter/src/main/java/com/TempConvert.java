import java.util.Scanner;

public class TempConvert {

    public static void main(String[] args) {
        TempConvert tempConvert = new TempConvert();
        tempConvert.run();
    }

    public void run() {

        Scanner keyboard = new Scanner(System.in);

        System.out.println("Please enter the temperature: ");
        String tempAsString = keyboard.nextLine();
        int tempAsInt = Integer.parseInt(tempAsString);

        System.out.println("Do you want to convert to Celsius (C) or Fahrenheit (F)?  ");
        String toFormat = keyboard.nextLine().toLowerCase();
        String tempFormat = "";
        String startingFormat = "";
        if (toFormat.equals("c")) {
            tempFormat = "Celsius";
            startingFormat = "Fahrenheit";
        } else {
            tempFormat = "Fahrenheit";
            startingFormat = "Celsius";
        }

        double convertedTemp = 0;
        boolean isNotValid = true;

        while (isNotValid) {
            toFormat = keyboard.nextLine().toLowerCase();
            if (toFormat.equalsIgnoreCase("c")) {
                convertedTemp = Math.round(convertFToC(tempAsInt));
                isNotValid = false;
            } else if (toFormat.equalsIgnoreCase("f")) {
                convertedTemp = Math.round(convertCToF(tempAsInt));
                isNotValid = false;
            } else {
                System.out.println("Please enter a valid temperature format (C or F) ");
            }
        }

        System.out.println(tempAsString + "° " + startingFormat + " converted to " + tempFormat + " is " + convertedTemp + "° " + tempFormat + ".");

    }

    public double convertFToC (int fahrenheit) {
        return Double.parseDouble(String.valueOf((fahrenheit - 32) / 1.8));
    }

    public double convertCToF (int celsius) {
        return Double.parseDouble(String.valueOf((celsius * 1.8) + 32));
    }

}
