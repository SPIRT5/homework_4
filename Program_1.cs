Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число, введите число!";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}


int number = GetNumber("Введите число: ");
int numberDegree = GetNumber("Введите степень, в которую хотите возвести: ");

double result = Math.Pow(number, numberDegree);

Console.WriteLine("Результат: " + result);