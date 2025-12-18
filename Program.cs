using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        string file_name = "C";
        Game game = new Game();
        game.create("hero");
        Database database = new Database();
        CoreTests tests = new CoreTests();
        database.writing_of_all_database_of_class_Game_into_txt_file(file_name, game);
        Console.WriteLine("Do you want to recover all information from the last time or continue or exit?!(recover or continue or exit)");
        string answer = Console.ReadLine();
        while (answer != "break")
        {
            if (answer == "recover")
            {
                Console.WriteLine("Enter the name of your file:");
                file_name = Console.ReadLine();
                database.reading_of_all_database_of_class_Game_from_txt_file(file_name);
                Console.WriteLine("Do you want to recover all information from the last time or continue or exit?!(recover or continue or exit)");
                answer = Console.ReadLine();
            }
            else if (answer == "continue")
            {
                game.create("hero");
                database.writing_of_all_database_of_class_Game_into_txt_file(file_name, game);
                Console.WriteLine("Do you want to recover all information from the last time or continue or exit?!(recover or continue or exit)");
                answer = Console.ReadLine();
            }
            else if(answer == "exit")
            {
                Console.WriteLine("Exiting the game.");
                break;
            }
        }
        Console.WriteLine("Do you want to do some tests?!(Enter yes or no)");
        string answer2 = Console.ReadLine();
        if (answer2 == "yes")
        {
            tests.GameFake_DoesNotThrow();
            tests.GameStub_ThrowsOnBadInput();
            tests.GameMock_TracksMethodCalls();
        }
        else
        {
            Console.WriteLine("Exiting the tests.");
        }    
    }
}
