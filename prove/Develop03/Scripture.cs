public class Scripture
{
    private Reference _scriptureReference; 
    private List<Word> _words;            

    public Scripture(string reference, string text)
    {
        _scriptureReference = new Reference(reference);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public Reference GetScriptureReference()
    {
        return _scriptureReference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Min(3, _words.Count); 
        var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < wordsToHide; i++)
        {
            if (unhiddenWords.Count == 0) break;
            int randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
            unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();  
        }
    }

    public string GetDisplayText()
    {
        return $"{_scriptureReference}\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}
