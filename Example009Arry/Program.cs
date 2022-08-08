int Max(int arg1, int arg2, int arg3)//, int arg4)
{
int result = arg1;
if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
//        if (arg4 > result) result = arg4;
return result;
}

int[] array = {121, 53, 542, 23, 73, 234, 75, 123, 345};//, 25, 213, 345};
array[3] = 324;


int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));//, Max(array[9], array[10], array[11]));

Console.WriteLine(max);