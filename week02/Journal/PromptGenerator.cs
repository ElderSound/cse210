
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I met today?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What could I have done better today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
 