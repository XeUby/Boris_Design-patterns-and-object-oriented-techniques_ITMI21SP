namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        public void Print(string message)
        {
            // Output: print out the string message 
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public class MathExam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
        }
    }

    // TODO#5: Add new ScienceExam class

    // TODO#6: Add another ProgrammingExam class

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            // TODO#8: Test that the created Printer works, by calling the Print method

            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance

            // TODO#10: Use Abstract Factory to create different types of exams.
        }
    }

}
