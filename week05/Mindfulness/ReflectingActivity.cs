public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Reflecting Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        duration = 50;
    }
    public void Run()
    {

    }

    //

    //

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}