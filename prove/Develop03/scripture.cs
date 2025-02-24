public class Scripture
{
    private List<Word> _wordList;
    private List<int> _hiddenIndexes;
    private Reference _reference;
    public Scripture(Reference reference, string sentence)
    {
        _wordList = new List<Word>();
        _hiddenIndexes = new List<int>();
        string[] words = sentence.Split(' '); // Split sentence by spaces between words

        _reference = reference;

        foreach (string word in words)
        {
            _wordList.Add(new Word(word)); // Add each word to the list.
        }
    }
    public bool HideThreeRandomWords()
    {
        Random rng = new Random();

        int wordsToHide = Math.Min(3, _wordList.Count - _hiddenIndexes.Count); // Defines the amount of words we are hiding each time.

        List<int> chosenIndexes = new List<int>(); // Stores the indexes that have already been chosen to hide.

        // Runs only while the number of chosen indexes is less than the amount of words I decided to hide.
        while (chosenIndexes.Count < wordsToHide) 
        {
            // Chooses a random positive integer within the range of the length of the list of words.
            int randomIndex = rng.Next(_wordList.Count);
            
            if (!_hiddenIndexes.Contains(randomIndex)) // If the random index has not already been hidden in past iterations
            {   
                if (!chosenIndexes.Contains(randomIndex)) // If the random index has not already been hidden in the current iteration
                {
                    chosenIndexes.Add(randomIndex); // Add it to the list of chosen indexes and --
                    _wordList[randomIndex].Hide(); // Hide the word pertaining to the random index.
                    _hiddenIndexes.Add(randomIndex); // Adds to the list of indexes that are already hidden.
                }
            }
        }
        return wordsToHide != 0;
    }
    public string GetWordDisplay()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _wordList)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return _reference.GetReference() + " " + string.Join(" ", displayWords);
    }
}