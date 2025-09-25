using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public void Display()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds - Comments({GetCommentCount()}):");
        foreach (Comment c in _comments)
        {
            Console.WriteLine($" - {c._name}: {c._text}");
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    } 


}