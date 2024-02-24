using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter something: ");

        var message = "";
        var previousNum = 0; 
        var tuloy = true;

        while (tuloy) {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") {
                Console.WriteLine("\nClosing program...");
                break;
            }

            int num;
            bool isNumeric = int.TryParse(input, out num);

            if (isNumeric) {
                int currentNum = int.Parse(input);
                int sum = previousNum + currentNum;
                Console.WriteLine($"Adding {previousNum} to {currentNum} = {sum}");
                previousNum = currentNum;
            }
            else {
                message += input + " ";
            }
            Console.WriteLine(message);
            Console.Write("Enter something: ");
        }
    }
}