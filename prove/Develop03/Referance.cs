public class Referance
{
    private string _book = "";
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    private void DisplayRef(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

        if (endVerse > 0)
        {
            Console.WriteLine($"{book} {chapter}: {startVerse} - {endVerse}");
        }
        else
        {
            Console.WriteLine($"{book} {chapter}: {startVerse}");
        }
    }
}