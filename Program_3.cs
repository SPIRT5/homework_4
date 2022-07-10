Console.Clear();

Random rnd = new Random();
int length = 8;
int[] numberArray = new int[length];

for (int i = 0; i < length; i++)
{
    numberArray[i] = rnd.Next(-100, 101);
    Console.Write(numberArray[i] + ", ");
}

Console.WriteLine("");