public class Prompt
{

    string[] prompts = {"How was your day?","What did you think about today?","Did you do anything fun today?"};
    Random rnd = new Random();
    int promptInt =  rnd.Next(prompts.Length);
    
    public string GetRandomPromt()
    {
        
        return "This is a prompt";
    }
}