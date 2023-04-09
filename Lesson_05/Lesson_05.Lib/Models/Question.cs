namespace Models;

public class Question 
{
    public string Text;
    public string[] Answers;
    public int CorrectAnswerNumber;

    public string GetText(int number)
    {
        return Text;
    }
}