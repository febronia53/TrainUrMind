using TrainUrMind.Section3.ProblemsSection3;

namespace TrainUrMind.Section3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Section 3 Problems,\n\nPlease choose a problem to solve (1-25):\n");

            int problemChoice = int.Parse(Console.ReadLine());

            switch (problemChoice)
            {
                case 1:
                    Console.WriteLine("Enter a string:");
                    string input1 = Console.ReadLine();
                    PrintStringClass.PrintString(input1);
                    break;

                case 2:
                    Console.WriteLine("Enter a string:");
                    string input2 = Console.ReadLine();
                    Console.WriteLine($"Length of the string is: {CheckStringLengthClass.GetStringLength(input2)}");
                    break;

                case 3:
                    Console.WriteLine("Enter a string:");
                    string input3 = Console.ReadLine();
                    SeparateCharactersClass.SeparateCharacters(input3);
                    break;

                case 4:
                    Console.WriteLine("Enter a string:");
                    string input4 = Console.ReadLine();
                     ReverseStringClass.PrintReverseString(input4);
                    
                    break;

                case 5:
                    Console.WriteLine("Enter a string:");
                    string input5 = Console.ReadLine();
                    Console.WriteLine($"Total number of words in the string is: {CountWordsClass.CountWords(input5)}");
                    break;

                case 6:
                    Console.WriteLine("Enter the 1st string:");
                    string str1_6 = Console.ReadLine();
                    Console.WriteLine("Enter the 2nd string:");
                    string str2_6 = Console.ReadLine();
                    Console.WriteLine(CompareStringsClass.CompareStrings(str1_6, str2_6));
                    break;

                case 7:
                    Console.WriteLine("Enter a string:");
                    string input7 = Console.ReadLine();
                    var counts = CountCharactersClass.CountCharacters(input7);
                    Console.WriteLine($"Number of Alphabets: {counts.Item1}");
                    Console.WriteLine($"Number of Digits: {counts.Item2}");
                    Console.WriteLine($"Number of Special characters: {counts.Item3}");
                    break;

                case 8:
                    Console.WriteLine("Enter a string:");
                    string input8 = Console.ReadLine();
                    var copiedStrings = CopyStringClass.CopyString(input8);
                    Console.WriteLine($"The First string is: {copiedStrings.Item1}");
                    Console.WriteLine($"The Second string is: {copiedStrings.Item2}");
                    Console.WriteLine($"Number of characters copied: {copiedStrings.Item1.Length}");
                    break;

                case 9:
                    Console.WriteLine("Enter a string:");
                    string input9 = Console.ReadLine();
                    var vowelConsonantCounts = CountVowelsConsonantsClass.CountVowelsConsonants(input9);
                    Console.WriteLine($"Total number of vowels: {vowelConsonantCounts.Item1}");
                    Console.WriteLine($"Total number of consonants: {vowelConsonantCounts.Item2}");
                    break;

                case 10:
                    Console.WriteLine("Enter a string:");
                    string input10 = Console.ReadLine();
                    var maxCharInfo = MaxCharacterFrequencyClass.MaxCharacterFrequency(input10);
                    Console.WriteLine($"The Highest frequency of character '{maxCharInfo.Item1}' appears {maxCharInfo.Item2} times");
                    break;

                case 11:
                    Console.WriteLine("Enter a string:");
                    string input11 = Console.ReadLine();
                    var sortedString = SortStringArrayClass.SortString(input11);
                    Console.WriteLine("After sorting the string appears like:");
                    Console.WriteLine(sortedString);
                    break;

                case 12:
                    Console.WriteLine("Enter number of strings:");
                    int numStrings12 = int.Parse(Console.ReadLine());
                    string[] strings12 = new string[numStrings12];
                    for (int i = 0; i < numStrings12; i++)
                    {
                        Console.WriteLine($"Enter string {i + 1}:");
                        strings12[i] = Console.ReadLine();
                    }
                    var sortedStrings = BubbleSortClass.BubbleSort(strings12);
                    Console.WriteLine("After sorting the array appears like:");
                    foreach (var str in sortedStrings)
                    {
                        Console.WriteLine(str);
                    }
                    break;

                case 13:
                    Console.WriteLine("Enter a string:");
                    string input13 = Console.ReadLine();
                    Console.WriteLine("Enter start position:");
                    int startPos13 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length:");
                    int length13 = int.Parse(Console.ReadLine());
                    Console.WriteLine(ExtractSubstringClass.ExtractSubstring(input13, startPos13, length13));
                    break;

                case 14:
                    Console.WriteLine("Enter a string:");
                    string input14 = Console.ReadLine();
                    Console.WriteLine("Enter substring to search:");
                    string substring14 = Console.ReadLine();
                    Console.WriteLine(CheckSubstringExistenceClass.IsSubstringPresent(input14, substring14) ? "Substring found" : "Substring not found");
                    break;

                case 15:
                    Console.WriteLine("Enter a string:");
                    string input15 = Console.ReadLine();
                    Console.WriteLine(ConvertCaseClass.ConvertCase(input15));
                    break;

                case 16:
                    Console.WriteLine("Sorry it's not implemented now");
                       break;

                case 17:
                    Console.WriteLine("Enter a string:");
                    string input17 = Console.ReadLine();
                    Console.WriteLine("Enter substring to search:");
                    string substring17 = Console.ReadLine();
                    Console.WriteLine($"Position: {SubstringPositionClass.SearchSubstringPosition(input17, substring17)}");
                    break;

                case 18:
                    Console.WriteLine("Enter a character:");
                    char input18 = char.Parse(Console.ReadLine());
                    Console.WriteLine(CharacterCaseCheckClass.CharacterCaseCheck(input18));
                    break;

                case 19:
                    Console.WriteLine("Enter a string:");
                    string input19 = Console.ReadLine();
                    Console.WriteLine("Enter substring to search:");
                    string substring19 = Console.ReadLine();
                    Console.WriteLine($"Occurrences: {SubstringPositionClass.SearchSubstringPosition(input19, substring19)}");
                    break;

                case 20:
                    Console.WriteLine("Enter a string:");
                    string input20 = Console.ReadLine();
                    Console.WriteLine("Enter the string to search:");
                    string toSearch20 = Console.ReadLine();
                    Console.WriteLine("Enter the string to insert:");
                    string toInsert20 = Console.ReadLine();
                    Console.WriteLine(InsertSubstringClass.InsertSubstring(input20, toSearch20, toInsert20));
                    break;

                case 21:
                    Console.WriteLine("Enter first string:");
                    string str1_21 = Console.ReadLine();
                    Console.WriteLine("Enter second string:");
                    string str2_21 = Console.ReadLine();
                    Console.WriteLine("Enter start position for first string:");
                    int start1_21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for first string:");
                    int length1_21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter start position for second string:");
                    int start2_21 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for second string:");
                    int length2_21 = int.Parse(Console.ReadLine());
                    Console.WriteLine(SubstringComparisonClass.CompareSubstrings(str1_21, str2_21, start1_21, length1_21, start2_21, length2_21));
                    break;

                case 22:
                    Console.WriteLine("Enter first string:");
                    string str1_22 = Console.ReadLine();
                    Console.WriteLine("Enter second string:");
                    string str2_22 = Console.ReadLine();
                    Console.WriteLine("Enter start position for first string:");
                    int start1_22 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for first string:");
                    int length1_22 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter start position for second string:");
                    int start2_22 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for second string:");
                    int length2_22 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CaseInsensitiveSubstringComparisonClass.CompareSubstringsIgnoreCase(str1_22, str2_22, start1_22, length1_22, start2_22, length2_22));
                    Console.WriteLine(CaseInsensitiveSubstringComparisonClass.CompareSubstringsHonorCase(str1_22, str2_22, start1_22, length1_22, start2_22, length2_22));
                    break;

                case 23:
                    Console.WriteLine("Enter first string:");
                    string str1_23 = Console.ReadLine();
                    Console.WriteLine("Enter second string:");
                    string str2_23 = Console.ReadLine();
                    Console.WriteLine("Enter start position for first string:");
                    int start1_23 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for first string:");
                    int length1_23 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter start position for second string:");
                    int start2_23 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter length for second string:");
                    int length2_23 = int.Parse(Console.ReadLine());
                    Console.WriteLine(SubstringComparisonCultureClass.CompareSubstringsTurkishCulture(str1_23, str2_23, start1_23, length1_23, start2_23, length2_23));
                    Console.WriteLine(SubstringComparisonCultureClass.CompareSubstringsInvariantCulture(str1_23, str2_23, start1_23, length1_23, start2_23, length2_23));
                    break;

                case 24:
                    Console.WriteLine("Enter number of names:");
                    int numNames24 = int.Parse(Console.ReadLine());
                    string[] names24 = new string[numNames24];
                    for (int i = 0; i < numNames24; i++)
                    {
                        Console.WriteLine($"Enter name {i + 1}:");
                        names24[i] = Console.ReadLine();
                    }
                    var sortedNames = LastNameSortingClass.SortByLastName(names24);
                    Console.WriteLine("Sorted names by last name:");
                    foreach (var name in sortedNames)
                    {
                        Console.WriteLine(name);
                    }
                    break;

                case 25:
                    Console.WriteLine("Enter first word set:");
                    string str1_25 = Console.ReadLine();
                    Console.WriteLine("Enter second word set:");
                    string str2_25 = Console.ReadLine();
                    Console.WriteLine(WordComparisonClass.CompareWords(str1_25, str2_25));
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}