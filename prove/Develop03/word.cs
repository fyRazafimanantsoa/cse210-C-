using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word (String text)
    {
        _text = text;
        _isHidden = false;
    
    } 

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        else
        {
            return _text;
        }
    }
     public bool IsHidden()
    {
        return _isHidden;
    }
}
