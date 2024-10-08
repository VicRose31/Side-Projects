import java.util.Scanner;

public class App {

    private final Scanner keyboard = new Scanner(System.in);
    public static void main(String[] args) {

        App app = new App();
        app.run();
    }

    private void run() {

        int questionsInSet = 0;
        int withoutPrompt = 0;
        int withPrompt = 0;
        int unanswered = 0;
        boolean isANumber = false;

        System.out.println("How many questions are in this set?");

        while (!isANumber) {
            String userInput = keyboard.nextLine();                         //get user input for # of questions
            try {
                questionsInSet = Integer.parseInt(userInput);
                isANumber = true;
                System.out.println("There will be " + questionsInSet + " questions in this set." + "\n");
            } catch (NumberFormatException e) {
                System.out.println("Please enter a number to represent the amount of questions in the current set.");
            }
        }

        System.out.println("For each question in the set: ");
        System.out.println("Press 'Y' if the student answers without any prompting.");
        System.out.println("Press 'H' if the student answers with the help of a prompt.");
        System.out.println("Press 'N' if the student is unable to provide an answer." + "\n");

        boolean isReady = false;
        while (!isReady) {
            System.out.println("When you are ready to begin, please press the 'Enter' key.");
            String readString = keyboard.nextLine();
            if (readString.isEmpty()) {
                isReady = true;
            }
        }

        for (int i = 1; i <= questionsInSet; i++) {
            boolean isValidResponse = false;
            System.out.println("\n" + "Question " + i + ": " + "\n" + "(Y) without help" +
                    "\n" + "(H) with help" + "\n" + "(N) no answer" + "\n");

            while (!isValidResponse) {
                String answer = keyboard.nextLine();

                if (answer.equalsIgnoreCase("y")) {
                    withoutPrompt++;
                    isValidResponse = true;
                } else if (answer.equalsIgnoreCase("h")) {
                    withPrompt++;
                    isValidResponse = true;
                } else if (answer.equalsIgnoreCase("n")) {
                    unanswered++;
                    isValidResponse = true;
                } else {
                    System.out.println("Please enter a valid response: Y, H, or N.");
                }
            }
        }

        double totalWithoutPrompt = ((double) withoutPrompt / questionsInSet) * 100;
        double totalWithPrompt = ((double) withPrompt / questionsInSet) * 100;
        int answered = withoutPrompt + withPrompt;
        double totalAnswered = ((double) answered / questionsInSet) * 100;
        double totalUnanswered = ((double) unanswered / questionsInSet) * 100;

        System.out.println("Questions answered without prompt:            " + withoutPrompt + "/" + questionsInSet + " or " + totalWithoutPrompt + "%.");
        System.out.println("Questions answered with prompt:               " + withPrompt + "/" + questionsInSet + " or " + totalWithPrompt + "%.");
        System.out.println("Questions answered with and without prompt:   " + answered + "/" + questionsInSet + " or " + totalAnswered + "%.");
        System.out.println("Questions unanswered:                         " + unanswered + "/" + questionsInSet + " or " + totalUnanswered + "%.");





    }
}
