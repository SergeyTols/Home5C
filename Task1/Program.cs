Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;
int[] array = new int[N];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);

        if(array[i] % 2 == 0)
        {
            count++;
        }
    }

void WriteArray(int[] test)
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
Console.WriteLine("\nКоличество чётных чисел в массиве: " +count);