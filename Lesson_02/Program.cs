// See https://aka.ms/new-console-template for more information

AskUser("What is the capital of France?", "Paris", 3);


bool AskUser(string question, string correctAnswer, int tries)
{
    Console.WriteLine(question);
    string userAnswer = Console.ReadLine();
    if (userAnswer == correctAnswer) {
        Console.WriteLine("Correct");
        return true;
    } else {
        Console.WriteLine("Incorrect");
        if (tries == 1) {
            Console.WriteLine("You have run out of tries");
            return false;
        }

        return AskUser(question, correctAnswer, tries - 1);
    }
}