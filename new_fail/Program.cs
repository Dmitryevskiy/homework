int[] NewArray()
{
    Random rand = new Random();
    int[] Array = new int[rand.Next(10, 20)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rand.Next(1, 200);
    }
    return Array;
}

(int[], int) NambersTru(int[] Array)
{
    int[] pul = new int[Array.Length];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            pul[j] = Array[i];
            j++;
        }
    }
    return (pul, j);
}

void PrintArray(int[] Array, int arg)
{
    if (arg == 0) arg = Array.Length;
    for (int i=0; i<arg;i++)
        {
            Console.Write($"{Array[i]} ");
        }
    Console.WriteLine();       
}

int[] Array = NewArray();
(int[] Even, int TwoNum) = NambersTru(Array);

PrintArray(Array, 0);
PrintArray(Even, TwoNum);
