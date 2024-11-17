
namespace ConsoleAppUsing{
   internal abstract class Program{
      private static void Main()
      {
          const string path = @"C:\temp\FIle.txt";
          using (var fs = new FileStream(path, FileMode.Open)){
              using (var sr = new StreamReader(fs)){
                  while (!sr.EndOfStream)
                  {
                      Console.WriteLine(sr.ReadLine());
                  }
              }
          }
      }
    }
}