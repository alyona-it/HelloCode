// Итерация 1. А сейчас перепишем этот код с использованием генератора псевдослучайных чисел с использованием методов. 
// Мы потренируем то, каким образом можно взять, например, метод, передать в него массив и заполнить массив нужным 
// количеством элементов. На следующем этапе опишем метод, который будет выводить все элементы по порядку. 
// Затем превратим наш код поиска нужного индекса в метод.

// Итерация 2. Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    //index = index +1; 
    index++;
  }
}

void PrintArray(int[] col)
{
  int count = col.Length; // count это length 
  int position = 0; // position это index
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }

}


int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;

  while (index < count)
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


int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);