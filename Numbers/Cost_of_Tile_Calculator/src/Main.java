import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);


        //Get room width from user, and check that width is not zero or negative
        System.out.println("Please enter the width of the room in feet: ");
        double widthAsDouble = Double.parseDouble(keyboard.nextLine());
        boolean isNotValid = true;

        while (isNotValid) {
            if (widthAsDouble <= 0) {
                System.out.println("Please enter a width that is greater than zero.");
                widthAsDouble = Double.parseDouble(keyboard.nextLine());
            } else {
                isNotValid = false;
            }
        }


        //Get room length from user, and check that length is not zero or negative
        System.out.println("Please enter the length of the room in feet: ");
        double lengthAsDouble = Double.parseDouble(keyboard.nextLine());
        isNotValid = true;
        while (isNotValid) {
            if (lengthAsDouble <= 0) {
                System.out.println("Please enter a length that is greater than zero.");
                lengthAsDouble = Double.parseDouble(keyboard.nextLine());
            } else {
                isNotValid = false;
            }
        }

        double areaOfRoom = widthAsDouble * lengthAsDouble;
        BigDecimal areaAsBigDec = new BigDecimal(String.valueOf(areaOfRoom));


        System.out.println("Please enter the cost of the flooring per square foot in dollars: ");
        String costAsString = keyboard.nextLine();
        BigDecimal costAsBigDec = new BigDecimal(costAsString);

        BigDecimal finalCost = areaAsBigDec.multiply(costAsBigDec).setScale(2, BigDecimal.ROUND_HALF_UP);
        System.out.println("The area ( " + areaAsBigDec + " ) multiplied by the cost per square foot ( $"
                + costAsString + " ) results in $" + finalCost + " for the total cost of flooring for the room.");
    }
}