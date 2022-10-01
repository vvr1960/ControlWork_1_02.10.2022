//Написать программу, которая из имеюшегося массива строк формирует массив из строк, меньше либо равных трем символам." 



      // 1. Объявляем переменных
      string[] Arr; 
      int count; 
      string stroka;
      string[] Arr2; 

      // 2. Ввод строк с клавиатуры.
      Console.WriteLine("Введите строки через клавишу Enter:");

      count = 0; 
      Arr = new string[count]; 

      do
      {
        stroka = Console.ReadLine() ?? "0";

        // Проверка количества символов в строке
        if (stroka.Length <= 3)
        {
          // если строка содержит меньше или рано три символа, то добавпяем строку в массив
          count++;

          Arr2 = new string[count];

          for (int i = 0; i < Arr2.Length - 1; i++)
              Arr2[i] = Arr[i];

              Arr2[count - 1] = stroka;

              Arr = Arr2;
        }
      } while (stroka != "");

      // 3. Вывод массива строк, с количеством символов меньше или равным трём.

      for (int i = 0; i < Arr.Length - 1; i++)
        Console.WriteLine("Arr[{0}] = {1}", i, Arr[i]);
        Console.ReadKey();
   
