// Вызвать тип данных
/*
int a = 12;
Console.WriteLine(a.GetType());
Console.WriteLine(a.GetType().Name);

var a = 12;
Console.WriteLine(a.GetType());
*/

// Парсинг входной строки
/*
using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "") //Заменить скобку на пробел
                .Replace(")", "")
                ;
Console.WriteLine(text);
var data = text.Split(" ") //Сделать разделитель пробел
                .Select(item => item.Split(',')) //Взять айтемы и разбить их с помощью запятой
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) //Сделать выборку из текущего массива, так чтобы первое число было первой координатой массива и т.д.
                .Where(e => e.x % 2 == 0) //Проверка условия (первая коодината четная)
                .Select(point => (point.x*10, point.y)) //Взять предыдущий набор и изменить первую координату
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); //Вывод массива
    Console.WriteLine();
}
*/
// Как писать комментарий
/// <summary>
/// Печать изображения
/// </summary>
/// <param name="row">Это строки </param>
/// <param name="col">Это столбцы </param>
/// <returns>Изображение</returns>