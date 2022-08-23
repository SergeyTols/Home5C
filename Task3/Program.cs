Console.Write("Введите длину массива: ");
uint N = Convert.ToUInt32(Console.ReadLine());

Double[] array = new Double[N];
Double min = 0;
Double max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        max = Math.Max(max, array[i]);
        min = Math.Min(min, array[i]);
        // if(array[i] < min)
        // {
        //     min = array[i];
        // }
        // if(array[i] > max)
        // {
        //     max = array[i];
        // }
    }
Double diff = max - min;
void WriteArray(double[] test)
{
    Console.Write("[");
    
        for(int i = 0; i < test.Length; i++)
        {
            if(i < test.Length -1)
            {
                Console.Write(test[i] + ", ");
            }   
            else
            {
                Console.Write(test[i] + "]");         
            }
        }
        
}

WriteArray(array);
Console.Write($"\nМаксимальное число: {max} \nМинимальное число: {min} \nРазница: {diff}");