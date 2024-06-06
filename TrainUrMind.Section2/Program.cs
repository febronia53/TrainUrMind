using TrainUrMind.Section2.ProblemsSection2;
using TrainUrMind.Section2.Section2;

namespace TrainUrMind.Section2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Section 2 Problems,\n\nPlease choose a problem to solve (1-24):\n");

            int problemChoice = int.Parse(Console.ReadLine());

            switch (problemChoice)
            {
                case 1:
                    Console.WriteLine("Enter two integers:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckEqualityClass.CheckEquality(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Enter an integer:");
                    int n = int.Parse(Console.ReadLine());
                    if (CheckEvenOddClass.CheckEvenOdd(n)) Console.WriteLine("Number is Even");
                    else Console.WriteLine("Number is Odd");
                    break;

                case 3:
                    Console.WriteLine("Enter an integer:");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckPositiveNegativeClass.CheckPositiveNegative(number));
                    break;

                case 4:
                    Console.WriteLine("Enter a year:");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckLeapYearClass.CheckLeapYear(year));
                    break;

                case 5:
                    Console.WriteLine("Enter your age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckVotingEligibilityClass.CheckVotingEligibility(age));
                    break;

                case 6:
                    Console.WriteLine("Enter an integer:");
                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine(DetermineNValueClass.DetermineNValue(m));
                    break;

                case 7:
                    Console.WriteLine("Enter a person's height in centimeters:");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine(CategorizeHeightClass.CategorizeHeight(height));
                    break;

                case 8:
                    Console.WriteLine("Enter three numbers:");
                    double numA = double.Parse(Console.ReadLine());
                    double numB = double.Parse(Console.ReadLine());
                    double numC = double.Parse(Console.ReadLine());
                    Console.WriteLine(FindLargestOfThreeClass.FindLargestOfThree(numA, numB, numC));
                    break;

                case 9:
                    Console.WriteLine("Enter X coordinate:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Y coordinate:");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine(DetermineQuadrantClass.DetermineQuadrant(x, y));
                    break;

                case 10:
                    Console.WriteLine("Enter marks obtained in Physics:");
                    int physics = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter marks obtained in Chemistry:");
                    int chemistry = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter marks obtained in Mathematics:");
                    int math = int.Parse(Console.ReadLine());
                    Console.WriteLine(DetermineProfessionalCourseEligibilityClass.DetermineProfessionalCourseEligibility(physics, chemistry, math));
                    break;

                case 11:
                    Console.WriteLine("Enter values for a, b, and c:");
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    double c = double.Parse(Console.ReadLine());
                    Console.WriteLine(ClassCalculateQuadraticRootsClass.CalculateQuadraticRoots(a, b, c));
                    break;

                case 12:
                    Console.WriteLine("Enter roll number:");
                    int rollNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter marks of Physics, Chemistry, and Computer Application:");
                    int physicsMark = int.Parse(Console.ReadLine());
                    int chemistryMark = int.Parse(Console.ReadLine());
                    int computerMark = int.Parse(Console.ReadLine());
                    CalculateTotalPercentageDivisionClass.CalculateAndDisplayStudentResults(rollNumber, name, physicsMark, chemistryMark, computerMark);
                    break;

                case 13:
                    Console.WriteLine("Enter temperature in centigrade:");
                    int temperature = int.Parse(Console.ReadLine());
                    Console.WriteLine(CategorizeTemperatureClass.CategorizeTemperature(temperature));
                    break;

                case 14:
                    Console.WriteLine("Enter three side lengths of a triangle:");
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    double side3 = double.Parse(Console.ReadLine());
                    Console.WriteLine(CheckTriangleTypeClass.CheckTriangleType(side1, side2, side3));
                    break;

                case 15:
                    Console.WriteLine("Enter three angles of a triangle:");
                    int angle1 = int.Parse(Console.ReadLine());
                    int angle2 = int.Parse(Console.ReadLine());
                    int angle3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(CheckTriangleValidityClass.CheckTriangleValidity(angle1, angle2, angle3));
                    break;

                case 16:
                    Console.WriteLine("Enter an alphabet letter:");
                    char alphabet = char.Parse(Console.ReadLine());
                    Console.WriteLine(CheckVowelConsonantClass.CheckVowelConsonant(alphabet));
                    break;

                case 17:
                    Console.WriteLine("Enter cost price and selling price:");
                    double costPrice = double.Parse(Console.ReadLine());
                    double sellingPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine(CalculateProfitLossClass.CalculateProfitLoss(costPrice, sellingPrice));
                    break;

                    case 18:
                    Console.WriteLine("Welcome to the Electricity Bill Calculator");
                    Console.WriteLine("Please enter customer details:");

                    Console.Write("Customer IDNO: ");
                    int customerId = int.Parse(Console.ReadLine());

                    Console.Write("Customer Name: ");
                    string customerName = Console.ReadLine();

                    Console.Write("Units Consumed: ");
                    int unitsConsumed = int.Parse(Console.ReadLine());

                    CalculateElectricityBillClass.CalculateElectricityBill(customerId, customerName, unitsConsumed);
                    break;


                case 19:
                    Console.WriteLine("Enter a grade:");
                    char grade = char.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertGradeToDescriptionClass.ConvertGradeToDescription(grade));
                    break;

                case 20:
                    Console.WriteLine("Enter a day number:");
                    int dayNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertDayNumberToDayNameClass.ConvertDayNumberToDayName(dayNumber));
                    break;

                case 21:
                    Console.WriteLine("Enter any digit:");
                    int digit = int.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertDigitToWordClass.ConvertDigitToWord(digit));
                    break;

                case 22:
                    Console.WriteLine("Enter month number:");
                    int monthNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(ConvertMonthNumberToNameClass.ConvertMonthNumberToName(monthNumber));
                    break;

                case 23:
                    Console.WriteLine("Enter month number:");
                    int monthNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetNumberOfDaysInMonthClass.GetNumberOfDaysInMonth(monthNum));
                    break;

                case 24:
                    Console.WriteLine("Choose a shape to calculate area:");
                    Console.WriteLine("1. Circle");
                    Console.WriteLine("2. Rectangle");
                    Console.WriteLine("3. Triangle");
                    int shapeChoice = int.Parse(Console.ReadLine());

                    switch (shapeChoice)
                    {
                        case 1:
                            Console.WriteLine("Input radius of the circle:");
                            double radius = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, radius));
                            break;
                        case 2:
                            Console.WriteLine("Input length of the rectangle:");
                            double length = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input width of the rectangle:");
                            double width = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, length, width));
                            break;
                        case 3:
                            Console.WriteLine("Input base length of the triangle:");
                            double baseLength = double.Parse(Console.ReadLine());
                            Console.WriteLine("Input height of the triangle:");
                            double h = double.Parse(Console.ReadLine());
                            Console.WriteLine("The area is: {0:F6}", CalculateAreaOfShapesClass.CalculateArea(shapeChoice, baseLength, h));
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
