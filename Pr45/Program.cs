int arraySize = 0;
arraySize = new Random().Next(2, 15);
int[] firstArray = new int[arraySize];
int[] secondArray = new int[arraySize];
 
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write("{0}", arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine("]");
}
 
void FillArray(int[] arrayToFill, int diviation)
{
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
}
 
void CopyArray(int[] arrayToCopy, int[] arrayToFill)
{
    for (int i = 0; i < arrayToCopy.Length; i++)
        arrayToFill[i] = arrayToCopy[i];
}
 
FillArray(firstArray, 20);
CopyArray(firstArray, secondArray);
 
Console.WriteLine("First array:");
PrintArray(firstArray);
Console.WriteLine("Second array:");
PrintArray(secondArray);