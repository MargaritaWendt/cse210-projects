public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _end;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _end = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _end = endVerse;
    }
    public string GetReferenceText()
    {
        if (_verse == _end)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_end}";
    }
}