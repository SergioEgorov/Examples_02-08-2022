int [] array = {1,76,33,4,53,61,76,87};

int n = array.Length;
int find = 76;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}