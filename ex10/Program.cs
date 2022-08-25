int[] array = {651, 22, 314, 4009, 5, 61, 7579, 83, 19};

int n = array.Length; //   возвращает длину массива
int find = 61;

int index = 0;

while (index<n)
{
   if(array[index]==find)
   {
        Console.WriteLine(index);
        break; //   оператор прерывания - для нахождения первого элемента
   }
   //index= index+1;
   index++;
}