int[] tf = {1,2,3,4,5,6,7,8,9};
int n = tf.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (tf[index] == find )
    {
        Console.WriteLine(index);
    }
    index++;
}