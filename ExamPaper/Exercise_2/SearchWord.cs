namespace ExamPaper.Exercise_2;


public class SearchWord
{
    static void Main(string[] args)
    {
        int count = 0;
        int index = -1;

        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter a word to search: ");
        string searchWord = Console.ReadLine();

        do
        {
            index = inputString.IndexOf(searchWord, index + 1);
            if (index != -1) count++;
        } while (index != -1);

        Console.WriteLine($"Word found {count} times in the string.");
        }
    }
    