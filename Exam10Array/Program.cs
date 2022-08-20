/* This is Function method of MAXIMUM of 3 numbers*/

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2> result) result = arg2;
if(arg3> result) result = arg3;
return result;
}
int a1 = 3, a2 = 54, a3 = 23, b1 = 64,b2 = 233, b3 = 31, c1 = 32, c2 = 3333, c3 = 34;
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
*/


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine (max);
