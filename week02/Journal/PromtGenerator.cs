public class PromptGenerator
{
  public List<string> _prompts = new List<string>()
  {
    "What was the best part of my day?",
    "What are the new skills that I adquired today?",
    "What was something interesting that happened today?",
    "How was my day today?",
    "Is there something now that I could give advice myself in the future?",
  };

  

  public string GetRandomPrompt()
    {
      Random random = new Random();
      int index = random.Next(_prompts.Count);

      return _prompts[index];
    }  
}