// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
//  меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.
// **Примеры:**
// `["hello", "2", "world", ":-)"]` -> `["2", ":-)"]`
// `["1234", "1567", "-2", "computer science"]` -> `["-2"]`

void Form3SymbolArray()
{
   Console.Clear();

   // Gets initial array
   string[] initArray = InputArray();

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
      // Checks the length of the array item is not greater then a maxElemLength {3} and is not equal 0
      if ((initialArray[i].Length <= maxElemLength) && (initialArray[i].Length != 0))
      {
         tmpArray[counter] = initialArray[i];
         counter++;
      }
      i++;
   }

   // Creates and fills a result array with data from the temporary array
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
   int i = 0;
   int arrLength = array.Length;
   int arrLengthDecr = arrLength - 1; // Array length without last element

   Console.Write("["); // Prints an opening bracket

   // Prints all elements of an array in a loop except the last one.
   if (arrLength > 0)
   {
      while (i < arrLengthDecr)
      {
         Console.Write("\"{0}\", ", array[i]);
         i++;
      }
      // Prints a last element of an array and a closing bracket if the array is not empty 
      Console.Write("\"{0}\"]", array[i]);
   }
   else
   // Prints an closing bracket if the array is empty 
   {
      Console.Write("]");
   }
}

// Inputs an array
string[] InputArray()
{
   string[] initArray = new string[]
   // {"Russia", "Denmark", "Kazan", ""};
   {"hello", "2", "", "world", ":-)"};
   // {"1234", "1567", "-2", "computer science"};
   return initArray;
}

Form3SymbolArray(); // Starts the main method