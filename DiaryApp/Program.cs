namespace DiaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DiaryHandler diaryHandler = new DiaryHandler();
           DiaryFileHandler diaryFileHandler = new DiaryFileHandler("diary.txt");


           while (true)
           {
               Console.WriteLine("Welcome to the Diary App!");
               Console.WriteLine("1. Add new diary note");
               Console.WriteLine("2. List all Diary notes");
               Console.WriteLine("3. Search diary note by date");
               Console.WriteLine("4. Save notes to file");
               Console.WriteLine("5. Load notes to file");
               Console.Write("Choose an option: ");
               string choice = Console.ReadLine();
                    

               switch (choice)
               {
                   case "1":
                       diaryHandler.AddEntry();
                       break;
                   case "2":
                       diaryHandler.ListEntries();
                       break;
                   case "3":
                       diaryHandler.SearchEntry();
                        break;
                    case "4":
                        diaryFileHandler.SaveEntries(diaryHandler.GetAllEntries());
                        break;
                    case "5":
                        var loaded = diaryFileHandler.LoadEntries();
                        diaryHandler.SetEntries(loaded);
                        break;
                    case "6":
                        Console.WriteLine("Good bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1-6.");
                        break;

                }
            }


        }
    }
}
