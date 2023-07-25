int[] array = { 1, 2, 4, 6, 2, 45, 34, 2, 6 };
int index = 0;
int n = array.Length;
int find = 6;

while(index < n)
{
    if(array[index] == find) 
    {
        Console.WriteLine(index);
        break;
        };
    index++;
}