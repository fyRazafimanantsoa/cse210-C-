public class Reference
{
    private string _text; // Private field to store the reference text

    public Reference(string reference)
    {
        _text = reference;
    }

    // Public method to access the reference text
    public string GetText()
    {
        return _text;
    }

    public override string ToString()
    {
        return _text;
    }
}
