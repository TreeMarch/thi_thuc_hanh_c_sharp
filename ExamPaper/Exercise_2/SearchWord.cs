namespace ExamPaper.Exercise_2;


public class SearchWord
{
    static void Main(string[] args)
    {
        
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();

            int count = 0;
            int index = inputString.IndexOf(searchWord, 0);

            while (index!= -1)
            {
                count++;
                index = inputString.IndexOf(searchWord, index + 1);
            }

            Console.WriteLine($"Word found {count} times in the string.");
        }
    }
    