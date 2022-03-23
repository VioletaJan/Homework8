// Write a program to do multiple calculation options with two numbers:
/*
●      Create two numerical variables with initial values.

●      Create an char type variable which represents the user option (please use the switch control):

a.      ‘+’ sum both elements;

b.     ’-’: do subtraction;

c.      ’/’: do dividing;

d.     ‘*’: do multiplication;

e.      ‘%’: get remainder when the first element is divided by the second element;

f.      ‘p’: print out both elements;

g.     ‘b’: verify which element is bigger;

h.     ‘s’:verify which element is smaller;

●      *Please add the possibility to write both variable values and the option in the console. Read, verify and do an algorithm
*/

Console.WriteLine("Please enter the first digit.");
double.TryParse(Console.ReadLine(), out double Num1);

Console.WriteLine("Please enter the second digit.");
double.TryParse(Console.ReadLine(), out double Num2);

Console.WriteLine("Please choose the option : '+', '-', '/', '*', '%', 'p' - for printing out both elements, 'b' - for verifying which element is bigger, 's'- for veryfying which element is smaller.");
char.TryParse(Console.ReadLine(), out char element);

switch (element)
{
    case '+':
        Console.WriteLine(Num1 + Num2);
    break;
  case '-':
        Console.WriteLine(Num1 - Num2);
    break;
    case '/':
        Console.WriteLine(Num1 * Num2);
        break;
    case '*':
        Console.WriteLine(Num1 * Num2);
        break;
    case '%':
        Console.WriteLine(Num1 % Num2);
        break;
    case 'p':
        Console.WriteLine(Num1);
        Console.WriteLine(Num2);
        break;
    case 'b':

        if (Num1 > Num2)
        {
            Console.WriteLine(Num1);
        }
        if (Num2 > Num1)
        {
            Console.WriteLine(Num2);
        }
        else
        {
            Console.WriteLine("Something went wrong, try again.");
        }
        break;
    case 's':
        Console.WriteLine();

        if (Num1 < Num2)
        {
            Console.WriteLine(Num1);
        }
        if (Num2 < Num1) ;

        else
        {
            Console.WriteLine("Something went wrong, try again.");
        }
        break;

}

//TEST