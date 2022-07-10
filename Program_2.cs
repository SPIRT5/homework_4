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

int result = 0;
int number = GetNumber("Введите число: ");

//Если число отрицательное, возникает ошибка в работе приложения, поэтому добавил перевод в положительное значение
if (number < 0) number = number * -1;
string numberStr = number.ToString();
int[] numberArray = new int[numberStr.Length];

for (int i = 0; i < numberStr.Length; i++)
{
    numberArray[i] = int.Parse(numberStr[i].ToString());
    result = result + numberArray[i];
}

Console.WriteLine("Результат: " + result);