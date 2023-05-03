public class Prompt
{

    List<string> _prompts;

    public Prompt()
    {
        _prompts.Add("How was your day?");
    }

    public string GetRandomPromt()
    {
        return "This is a prompt";
    }
}