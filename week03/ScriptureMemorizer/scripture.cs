using System.Reflection.Metadata;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');
        
        foreach (string wordtext in words)
        {
            Word word = new Word(wordtext);
            _words.Add(word);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    } 

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            text += " " + word.GetDisplayText();
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }   
}    