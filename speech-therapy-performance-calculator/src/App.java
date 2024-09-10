import java.util.Scanner;

public class App {

    private final Scanner keyboard = new Scanner(System.in);
    public static void main(String[] args) {

        App app = new App();
        app.run();
    }

    private void run() {

        double questionsInSet = 0.0;
        double answeredQuestions = 0.0;
        int withoutPrompt = 0;
        int withPrompt = 0;
        int notAnswered = 0;
        boolean isValidNumber = true;

        while (!isValidNumber) {
            System.out.println("How many questions are in this set?");
        }



        System.out.println("For each question in the set: ");
        System.out.println("Press 'Y' if the student answers without any prompting.");
        System.out.println("Press 'H' if the student answers with the help of a prompt.");
        System.out.println("Press 'N' if the student is unable to provide an answer.");



    }
}
