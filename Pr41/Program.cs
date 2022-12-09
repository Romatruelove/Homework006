Console.WriteLine("Введи любое количество чисел через запятую:");
string s = Console.ReadLine();
string[] line = s.Split(',');
int[] numbers = new int[line.Length];

void CountNum()
{
    int count = 0; 
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(line[i]);
        if(numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}
CountNum();