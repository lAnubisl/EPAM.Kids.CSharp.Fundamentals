using Models;
using Models.Item;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Question question = new Question();


        question.Answers = new string[] { "Paris", "London", "Berlin" };
        question.CorrectAnswerNumber = 1;
        question.Text = "What is the capital of France?";


        string json = Newtonsoft.Json.JsonConvert.SerializeObject(question);
        question.Text = "What is the capital of France?";
        MyProduct item = new MyProduct();
        Console.WriteLine("Hello, World!");
    }
}