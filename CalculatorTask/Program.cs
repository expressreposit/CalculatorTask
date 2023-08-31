// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using CalculatorTask;

public class Program
{
    public static void Main()
    {
        using (var db = new CalculatorContext())
        {
            db.Database.EnsureCreated();

            while (true)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. View History");
                Console.WriteLine("6. Exit");

                Console.Write("Select an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                {
                    Console.Write("Goodbye! ");
                    break;
                }

                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Enter Operand 1: ");
                    double operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Operand 2: ");
                    double operand2 = Convert.ToDouble(Console.ReadLine());

                    var (result, operation) = choice switch
                    {
                        1 => (operand1 + operand2, "Addition"),
                        2 => (operand1 - operand2, "Subtraction"),
                        3 => (operand1 * operand2, "Multiplication"),
                        4 when operand2 != 0 => (operand1 / operand2, "Division"),
                        4 => throw new DivideByZeroException("Cannot divide by zero."),
                        _ => throw new ArgumentException("Invalid choice.")
                    };
                    Console.WriteLine($"Result: {result}");

                    var calculation = new Calculation
                    {
                        Operation = operation,
                        Operand1 = operand1,
                        Operand2 = operand2,
                        Result = result
                    };

                    db.Calculations.Add(calculation);
                    db.SaveChanges();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Calculation History:");
                    var history = db.Calculations.OrderBy(c => c.CalculationId).ToList();
                    Console.WriteLine("ID| Operation |Operand1 |Operand2 | Result");
                    Console.WriteLine("--------------------------");
                    foreach (var item in history)
                    {
                        Console.WriteLine($"{item.CalculationId}.\t| {item.Operation} \t|{item.Operand1}  \t|{item.Operand2} \t| {item.Result}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
