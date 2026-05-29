class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    public string GetDisplayText()
    {
        string text = $"{_title}, {_author}, {_length}";
        return text;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int GetNumberComments()
    {
        return _comments.Count;
    }

}