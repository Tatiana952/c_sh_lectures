int[] array = {1, 2, 4, 6, 556, 46, 5, 556};

int n = array.Length;
int find = 556;
int index = 0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }

    index ++;
}