using System.Text;

// 1. Создание и удаление файла

// string path = @"D:\\test.txt";
// FileInfo fileInfo = new FileInfo(path);
// using (FileStream fs = fileInfo.Create()){}
// System.Console.WriteLine("File Created!");
// fileInfo.Delete();
// System.Console.WriteLine("File Deleted!");

// 3. Работа с файлами и папками

// string path = @"D:\\Test";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// directoryInfo.Create();
// string path2 = String.Concat(path, "\\Test1.txt");
// string path3 = String.Concat(path, "\\Test2.txt");
// string path4 = String.Concat(path, "\\Test3.txt");
// using (FileStream fs = new FileStream(path2,FileMode.Create)){}
// using (FileStream fs = new FileStream(path3,FileMode.Create)){}
// using (FileStream fs = new FileStream(path4,FileMode.Create)){}
// FileInfo[] files =  directoryInfo.GetFiles();
// foreach (var file in files)
// {
//     System.Console.WriteLine(file.Name);
// }

// 5. Поиск файла по имени

// string path = @"D:\\Test";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// FileInfo[] files = directoryInfo.GetFiles("*1*");
// foreach (var file in files)
// {
//     System.Console.WriteLine(file.Name);    
// }

//  6. Сравнение двух файлов

// string path1 = @"D:\\Test\\Test1.txt";
// string path2 = @"D:\\Test\\Test2.txt";
// string text1 = File.ReadAllText(path1);
// string text2 = File.ReadAllText(path2);
// if(text1 == text2)System.Console.WriteLine("They are copy");
// else System.Console.WriteLine("They are not copy");


// 7. Чтение большого файла частями

// string path = @"D:\\Test\\Test1.txt";
// string[] lines = File.ReadAllLines(path);
// foreach (var line in lines)
// {
//     System.Console.WriteLine(line);
// }

//  8. Переименование файла

// string path = @"D:\\Test\\Test1.txt";
// string path2 = @"D:\\Test\\Test4.txt";
// File.Move(path,path2);

//  9. Копирование файлов

// string path = @"D:\\Test";
// string path2 = @"D:\\Test2\\";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// FileInfo[] files = directoryInfo.GetFiles();
// foreach (var file in files)
// {
//     string path3 = path2 + file.Name;
//     file.CopyTo(path3, true);
// }

//  11. Проверка существования файла

// string path = @"D:\\Test\\Test1.txt";
// if(File.Exists(path))
// {
//     System.Console.WriteLine("File is exists");
// }
// else System.Console.WriteLine("File not found");

//  12. Чтение содержимого директории

// string path = "D:\\Test";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// DirectoryInfo[] directories = directoryInfo.GetDirectories();
// FileInfo[] files = directoryInfo.GetFiles();
// System.Console.WriteLine("Directories:");
// foreach (var directory in directories)
// {
//     System.Console.WriteLine(directory.Name);
// }
// System.Console.WriteLine("\nFiles:");
// foreach (var file in files)
// {
//     System.Console.WriteLine(file.Name);
// }

//  13. Удаление всех файлов с определённым расширением

// string path = @"D:\\Test";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// FileInfo[] files = directoryInfo.GetFiles("*.log");
// foreach (var file in files)
// {
//     FileInfo fileInfo = new FileInfo(file.FullName);
//     fileInfo.Delete();
// }

//  14. Копирование текстового файла с изменением содержания

// string path = @"D:\\Test\\Test1.txt";
// string path2 = @"D:\\Test\\Test2.txt";
// string text = File.ReadAllText(path);
// text = text.ToUpper();
// File.WriteAllText(path2, text);

//  16. Получение размера файла

// string path = @"D:\\Test\\Test1.txt";
// FileInfo fileInfo = new FileInfo(path);
// System.Console.WriteLine(fileInfo.Length);

//  17. Получение даты последнего изменения файла

// string path = @"D:\\Test\\Test1.txt";
// FileInfo fileInfo = new FileInfo(path);
// System.Console.WriteLine(fileInfo.LastAccessTime);

//  18. Перемещение файлов

// string path1 = @"D:\\Test\\Test1.txt";
// string path2 = @"D:\\Test1.txt";
// File.Move(path1,path2);

//  19. Запись строки в текстовый файл

// string path = @"D:\\Test\\Test1.txt";
// string text = "Hello everybody!";

// using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
// {
//     byte[] data = new UTF8Encoding(true).GetBytes(text);
//     fs.Write(data,0,data.Length);
// }

// 20. Поиск всех файлов с определённым расширением

// string path = @"D:\\Test";
// DirectoryInfo directoryInfo = new DirectoryInfo(path);
// FileInfo[] files = directoryInfo.GetFiles("*.txt");
// foreach (var file in files)
// {
//     System.Console.WriteLine(file.Name);    
// }
