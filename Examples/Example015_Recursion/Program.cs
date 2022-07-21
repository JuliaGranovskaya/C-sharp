/*
string path = "C:/Users/grano/OneDrive/Рабочий стол/GeekBrains/Знакомство с C#/Examples/Example002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
FileInfo[] files = catalog.GetFiles();
for (int i = 0; i < files.Length; i++)
{
    Console.WriteLine($"{indent}{files[i].Name}");
}
}
string path = @"C:/Users/grano/OneDrive/Рабочий стол/GeekBrains/Знакомство с C#/Examples/Example002_HelloUser";
CatalogInfo(path);
*/

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();