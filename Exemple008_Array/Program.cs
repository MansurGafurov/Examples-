﻿int Max ( int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// index       0    1    2  3  4   5  6   7   8
int[] array = {13, 22, 355, 4, 5, 65, 7, 88, 90 };


//int MaxNumber = Max(
//    Max(array[0], array[1], array[2]),
//    Max(array[3], array[4], array[5]),
//    Max(array[6], array[7], array[8]) 
//);
// это можно поместить в одну строчку


// это более длинный код 
int max1 = Max(array[0], array[1], array[2]);
int max2 = Max(array[3], array[4], array[5]);
int max3 = Max(array[6], array[7], array[8]);
int MaxNumber = Max(max1, max2, max3);

Console.WriteLine(MaxNumber);
