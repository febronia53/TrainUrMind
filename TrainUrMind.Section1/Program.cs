using TrainUrMind.Section1.ProblemsSection1;

namespace TrainUrMind.Section1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Section1 Problems,\n\nPlease Choose a problem to solve (1-25):\n");

            int problemChoice = int.Parse(Console.ReadLine());

            switch (problemChoice)
            {
                case 1:
                    Console.WriteLine("Enter two integers:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(ComputeSumClass.ComputeSum(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Enter an integer:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(AbsoluteDifferenceClass.AbsoluteDifference(n));
                    break;

                case 3:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckThirtyClass.CheckThirty(num1, num2));
                    break;

                case 4:
                    Console.WriteLine("Enter an integer:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckWithin10Of100Or200Class.CheckWithin10Of100Or200(n));
                    break;

                case 5:
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();
                    Console.WriteLine(AddIfPrefixClass.AddIfPrefix(str));
                    break;

                case 6:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine("Enter the position to remove:");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine(RemoveCharAtClass.RemoveCharAt(str, index));
                    break;

                case 7:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(ExchangeFirstLastClass.ExchangeFirstLast(str));
                    break;

                case 8:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(FourCopiesOfFirstTwoClass.FourCopiesOfFirstTwo(str));
                    break;

                case 9:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(AddLastCharFrontBackClass.AddLastCharFrontBack(str));
                    break;

                case 10:
                    Console.WriteLine("Enter an integer:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckMultipleOf3Or7Class.CheckMultipleOf3Or7(n));
                    break;

                case 11:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(AddFirst3CharsFrontBackClass.AddFirst3CharsFrontBack(str));
                    break;

                case 12:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(CheckStartsWithCSharpClass.CheckStartsWithCSharp(str));
                    break;

                case 13:
                    Console.WriteLine("Enter two temperatures:");
                    int temp1 = int.Parse(Console.ReadLine());
                    int temp2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckTemperaturesClass.CheckTemperatures(temp1, temp2));
                    break;

                case 14:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckRange100To200Class.CheckRange100To200(num1, num2));
                    break;

                case 15:
                    Console.WriteLine("Enter three integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    int num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckRange20To50Class.CheckRange20To50(num1, num2, num3));
                    break;

                case 16:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckRange20To50InclusiveClass.CheckRange20To50(num1, num2));
                    break;

                case 17:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(CheckYtAtIndex1Class.CheckYtAtIndex1(str));
                    break;

                case 18:
                    Console.WriteLine("Enter three integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(FindLargestClass.FindLargest(num1, num2, num3));
                    break;

                case 19:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(ClosestTo100Class.ClosestTo100(num1, num2));
                    break;

                case 20:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckRange40To50Or50To60Class.CheckRange(num1, num2));
                    break;

                case 21:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(LargestInRangeClass.FindLargestInRange(num1, num2));
                    break;

                case 22:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(CountZCharactersClass.ContainsBetween2And4Z(str));
                    break;

                case 23:
                    Console.WriteLine("Enter two integers:");
                    num1 = int.Parse(Console.ReadLine());
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(SameLastDigitClass.HaveSameLastDigit(num1, num2));
                    break;

                case 24:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine(UppercaseLast3CharsClass.ConvertLast3ToUpper(str));
                    break;

                case 25:
                    Console.WriteLine("Enter a string:");
                    str = Console.ReadLine();
                    Console.WriteLine("Enter the number of copies:");
                    int copies = int.Parse(Console.ReadLine());
                    Console.WriteLine(RepeatStringClass.RepeatString(str, copies));
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
