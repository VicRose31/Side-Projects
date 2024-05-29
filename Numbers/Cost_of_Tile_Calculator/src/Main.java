import java.math.BigDecimal;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);

        System.out.println("Please enter the width of the room in feet: ");
        double widthAsDouble = Double.parseDouble(keyboard.nextLine());

        System.out.println("Please enter the length of the room in feet: ");
        double lengthAsDouble = Double.parseDouble(keyboard.nextLine());

        double areaOfRoom = widthAsDouble * lengthAsDouble;
        BigDecimal areaAsBigDec = new BigDecimal(String.valueOf(areaOfRoom)); //change to BD

        System.out.println("Please enter the cost of the flooring per square foot in dollars: ");
        String costAsString = keyboard.nextLine();  //change to BD
        BigDecimal costAsBigDec = new BigDecimal(costAsString);

        BigDecimal finalCost = areaAsBigDec.multiply(costAsBigDec);
        System.out.println("The cost of flooring for this room is " + finalCost);
    }
}