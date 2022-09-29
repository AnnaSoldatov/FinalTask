string[] FillArray(int size){
string[] arrayStart = new string[size];
for (int i = 0; i < size; i++){
Console.WriteLine("Enter the elements: ");
string element = Convert.ToString(Console.ReadLine());
arrayStart[i] = element;
}
return arrayStart;
}


string[] NewArray(string[] arrayStart, int size){
string[] arrayFinal = new string[size];
int n = 3;
int i = 0;
for (int j = 0; j < size; j++)
{
    if (arrayStart[j].Length <= n)
    {
        arrayFinal[i] = arrayStart[j];
        i++;
    }
}
return arrayFinal;
}


void PrintArray(string[] array){
Console.Write("[ ");
for(int i = 0; i<array.Length;i++){
Console.Write(array[i] + " ");
}
Console.Write("]");
}


Console.WriteLine("Enter the array size: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(size);
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray(array, size));