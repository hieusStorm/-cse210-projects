public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "What was the best part of the day?", "Who was the most interesting person I interacted with today?", "What was the strongest emotion I felt today?", "If you could repeat one part of today what would it be?", "What was the coolest thing you saw today?", "What is one thing you'll do better tomorrow?" };

    public string GetRandomPrompt()
    {
        Random randomNumberGenerator = new Random();
        string prompt = _prompts[randomNumberGenerator.Next(_prompts.Count)];
        return prompt;
    }

}