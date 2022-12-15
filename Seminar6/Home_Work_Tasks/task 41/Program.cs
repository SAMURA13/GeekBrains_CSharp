//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//  Ввод чисел останавливается при помощи ввода стоп-слова "stop"

  string stop = "stop";
    string answer= Console.ReadLine();
    int count=0;
    for (int i = 0;answer != stop; i++)
    {

        if(i > 0)
        {
        count++;
        }  
        Console.Write($"Vvedite :  ");
        answer=i.ToString(Console.ReadLine());      
    }
    Console.Write($"Вы ввели четных чисел {count-1}");



