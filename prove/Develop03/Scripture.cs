public class Scripture
{
    List<string> words = new List<string>();
    private int _totalWords;
    private Random _randomNumber = new Random();

    public int RandomWord()
    {
        _totalWords = words.Count();
        int randomWord = _randomNumber.Next(0, _totalWords);
        return randomWord;
    
    }

    public void Display()
    {

    } 

    public void VerseCompleted()
    {
        
    }
}