// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.
// **Примеры:**
// `["hello", "2", "world", ":-)"]` -> `["2", ":-)"]`
// `["1234", "1567", "-2", "computer science"]` -> `["-2"]`

void Form3SymbolArray()
{
   // string[] initArray = new string[]
   // {
   //    "1234", "1567", "-2", "computer science"
   // };

   Console.Clear();
   // Initial array is apearing here
   // string[] initArray = new string[]
   // {
   //    "hello", "2", "world", ":-)"
   // };

   string[] initArray = new string[]
   {
      "Russia", "Denmark", "Kazan"
   };

   // Forms the array by conditions
   string[] resultArray = FormResultArray(initArray);

   // Prints the array to the console
   OutputArray(resultArray);
}

// Method for forming the resulting array
string[] FormResultArray(string[] initialArray)
{
   int i = 0;
   int counter = 0;
   int maxElemLength = 3;
   string[] tmpArray = new string[initialArray.Length]; // Creates temporary array

   // Fills a temporary array with data according to the required conditions
   while (i < initialArray.Length)
   {
      if ((initialArray[i].Length <= maxElemLength) && (initialArray[i].Length != 0))
      {
         tmpArray[counter] = initialArray[i];
         counter++;
      }
      i++;
   }

   // Fills a result array with data from the temporary array
   i = 0;
   string[] resultArray = new string[counter];
   while (i < counter)
   {
      resultArray[i] = tmpArray[i];
      i++;
   }
   return resultArray;
}

// Prints array of the strings
void OutputArray(string[] array)
{
   Console.Write("["); // Prints opening bracket
   int i = 0;
   // Prints all elements of an array in a loop except the last one.
   while (i < array.Length - 1)
   {
      Console.Write("\"{0}\", ", array[i]);
      i++;
   }
   Console.Write("\"{0}\"]", array[i]);
}

Form3SymbolArray(); // Starts the main method