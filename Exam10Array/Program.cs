/* This is Function method of MAXIMUM of 3 numbers

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2> result) result = arg2;
if(arg3> result) result = arg3;
return result;
}
int [] array = {1, 12, 5, 7, 45, 566, 84, 67, 109};

int max = Max(
    Max(array[0], array[1],array[2]),
    Max(array[3], array[4],array[5]),
    Max(array[6], array[7],array[8])
    );

Console.WriteLine (max);*/
/*
int [] array = {1, 12, 5, 7, 45, 566, 84, 45, 566, 109};
int n = array.Length;
int find = 566;
int index =0;
while(index<n)
{
    if (array[index] == find )
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/

 void SoArray(int [] collection)

 {
int Length = collection.Length;
int index = 0;
while (index<Length)
{

collection[index] = new Random ().Next(1,20);
Console.WriteLine();
index++;
}
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;
while(position<count)
{
    Console.WriteLine(col[position]);
    position++;
}

}

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position= -1;

while(index<count)
{
    if (collection[index] == find)
    {
        position = index;
        break;
    }
    index++;
}
return position;
}

int [] array = new int[20];

SoArray(array); //метод заполнения массива случайными числами//
PrintArray(array);//метод отображения массива//
Console.WriteLine(); // метод поиска числа в массиве //

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
