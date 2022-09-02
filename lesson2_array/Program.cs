int Max(int arg1,int arg2,int arg3)
{
    int result =arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
int [] kesha = {1, 4, 4000, 6, 7, 89, 988, 675, 86};

int max = Max(
    Max(kesha[0],kesha[1],kesha[2]),
    Max(kesha[3],kesha[4],kesha[5]),
    Max(kesha[6],kesha[7],kesha[8])
);
Console.WriteLine(max);