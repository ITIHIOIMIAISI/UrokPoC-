int[] array = {12, 345, 21, 76, 123, 75, 34, 12, 523, 568, 9634, 34, 456};

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}