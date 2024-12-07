public class Comment
{
    // Member variables
    private string _commenterName;
    private string _text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Methods
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}
