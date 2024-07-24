// See https://aka.ms/new-console-template for more information

using ExamPaper;

// ========================================================================== Exercise 01

// People people = new People();
//
// Console.Write("Enter Name: ");
// people.Name = Console.ReadLine();
//
// while (true)
// {
//     Console.Write("Enter Gender (Female/Male): ");
//     string genderInput = Console.ReadLine().Trim().ToLower();
//
//     if (genderInput == "female")
//     {
//         people.Gender = true;
//         break;
//     }
//     else if (genderInput == "male")
//     {
//         people.Gender = false;
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid input. Please enter 'Female' or 'Male'.");
//     }
// }
//
// Console.Write("Enter Age: ");
// people.Age = int.Parse(Console.ReadLine());
//
// Console.WriteLine("\nInitial values:");
// people.DisplayValue();
//
// people.Age += 10;
// Console.WriteLine("========================");
//
// Console.WriteLine("After incrementing Age:");
// people.DisplayValue();
//
// Console.ReadLine();


// ========================================================================== Exercise 02
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
