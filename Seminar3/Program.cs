// Поиск четверти по координатам
// void coordinate()
// {
//     int[] Input()
//     {
//         int[] Array = new int[2];
//         Console.WriteLine("Введите координату X: ");
//         int x = Convert.ToInt32(Console.ReadLine());
//         Array[0] = x;
//         Console.WriteLine("Введите координату Y: ");
//         int y = Convert.ToInt32(Console.ReadLine());
//         Array[1] = y;
//         return Array;
//     }
//     int[] mini = Input();
//     while (mini[0] == 0 || mini[1] == 0)
//     {
//         Console.WriteLine("Точка находится на оси");
//         mini = Input();
//     }

//     if (mini[0] > 0 && mini[1] > 0)
//     {
//         Console.WriteLine("Точка находится в первой четверти");
//     }

//     if (mini[0] > 0 && mini[1] < 0)
//     {
//         Console.WriteLine("Точка находится в четвертой четверти");
//     }

//     if (mini[0] < 0 && mini[1] > 0)
//     {
//         Console.WriteLine("Точка находится во второй четверти");
//     }

//     else if (mini[0] < 0 && mini[1] < 0)
//     {
//         Console.WriteLine("Точка находится в третьей четверти");
//     }
    
//     }
// coordinate();

// Вывод возможных координат по номеру четверти
// void quarter()
// {
//     Console.Write("Введите номер четверти: ");
//     int q = Convert.ToInt32(Console.ReadLine());

//     if (q > 4 || q < 1)
//     {
//         Console.WriteLine("Некорректное значение");
//     }
//     if (q == 1)
//     {
//         Console.WriteLine("X > 0, Y > 0");
//     }
//     if (q == 2)
//     {
//         Console.WriteLine("X < 0, Y > 0");
//     }
//     if (q == 3)
//     {
//         Console.WriteLine("X < 0, Y < 0");
//     }
//     if (q == 4)
//     {
//         Console.WriteLine("X > 0, Y < 0");
//     }
// }
// quarter();

// Найти расстояние между двумя точками
// void distance()
// {
//     Console.Write("Введите X координату первой точки: ");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату первой точки: ");
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите X координату второй точки: ");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату второй точки: ");
//     int By = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(Math.Sqrt((Ax - Bx)*(Ax - Bx) + (Ay - By)*(Ay - By)));
// }
// distance();

// Вывод таблицы квадратов чисел от 1 до N
// void squares()
// {
// Console.Write("Number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// Console.Write(""+ N +" -> ");
// while (count <= N)
//     {
//         Console.Write(""+ count*count +" ");
//         count = count + 1;
//     };
// }
// squares();