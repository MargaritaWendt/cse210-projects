public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
        duration = 50;
    }
    public void Run()
    {

    }

    //public string GetRandomPrompt(){}

    //public string GetListFromUser(List<string>) {}
}