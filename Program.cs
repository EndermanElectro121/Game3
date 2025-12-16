using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        /*var doc = new Presenter("Test document");
        doc.AddParagraph("Some thoughts...");
        doc.AddHeading("Top:");
        doc.AddParagraph("This is a line.");
        doc.AddParagraph("This is another line.");
        doc.AddHeading("Inner:", 1);
        doc.AddParagraph("This is an inner line.");
        doc.Up();
        doc.AddParagraph("Some closure...");
        Console.WriteLine(doc.Render());*/
        /*Character hero = new Character("Hero", 100, 50, 20);
        Data data = new Data(hero);
        data.ItemNames.Add((1, new Item("Sword", 100)));
        data.ItemNames.Add((2, new Item("Shield", 150)));
        data.AbilityNames.Add((1, new Ability("Slash", 30, 10)));
        data.AbilityNames.Add((2, new Ability("Block", 0, 5)));
        data.AbilityNames.Add((3, new Ability("Heal", -20, 15)));
        string data2 = data.ToString();
        Console.WriteLine(data2);*/
        /*Commands commands = new Commands(new Presenter("RPG Game CLI"));
        commands.Run();*/
        /*Text text = new Text();
        text.pwd();
        text.print();
        text.add();
        text.add();
        text.rm();
        text.cd();
        text.print(true);*/
        Game game = new Game();
        game.create("hero");
        Database database = new Database();
        CoreTests tests = new CoreTests();
        database.writing_of_all_database_of_class_Game_into_txt_file("D:\\Проэкты\\superman.txt", game);
        Console.WriteLine("Do you want to recover all information from the last time or continue or exit?!(recover or continue or exit)");
        string answer = Console.ReadLine();
        while (answer != "break")
        {
            if (answer == "recover")
            {
                database.reading_of_all_database_of_class_Game_from_txt_file("D:\\Проэкты\\superman.txt");
                Console.WriteLine("Do you want to recover all information from the last time or continue or exit?!(recover or continue or exit)");
                answer = Console.ReadLine();
            }
            else if (answer == "continue")
            {
                game.create("hero");
                database.writing_of_all_database_of_class_Game_into_txt_file("D:\\Проэкты\\superman.txt", game);
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
        //example of path of c
        /*CoreTests tests = new CoreTests();
        CLITests tests2 = new CLITests();
        InfraTests tests3 = new InfraTests();*/
        /*tests.GameFake_DoesNotThrow();
        tests.GameStub_ThrowsOnBadInput();
        tests.GameMock_TracksMethodCalls();*/
        /*tests2.CLI_Run_DoesNotThrow();
        tests2.Commands_Run_ProcessesCommands();
        tests2.Presenter_AddsAndRendersContent();
        tests2.Presenter_UpAtRoot_DoesNotThrow();
        tests2.Presenter_RenderEmptyDocument_ReturnsEmptyString();*/
        /*tests3.DisplayerFake_DoesNotThrow();
        tests3.DisplayerStub_ThrowsOnBadInput();
        tests3.DisplayerMock_TracksMethodCalls();*/
        /*/WebApi api = new WebApi();
        string url = "https://jsonplaceholder.typicode.com/todos/1";
        string result = api.GetThirdPartyDataAsync(url).Result;
        Console.WriteLine(result);*/
        /*var character = new Character("hero", 100, 100, 100);
        var todo = await character.GetCharacterAsync("https://jsonplaceholder.typicode.com/todos/1");
        Console.WriteLine($"Character UserId: {todo.userId}, character ID: {todo.id}, Title: {todo.title}, Completed: {todo.Completed}");
        Game game = new Game();
        Prototype prototype = new Prototype();
        Singleton singleton = new Singleton();
        game.create("character");
        prototype.characters = game.characters;
        prototype.enemies = game.enemies;
        prototype.Prototypels("hero");
        prototype.Prototypels("enemy");
        for(int i = 0; i < prototype.characters.Count; i++)
        {
            Console.WriteLine($"Character {i+1}: {prototype.characters[i].Name}, Health: {prototype.characters[i].Health}, Armor: {prototype.characters[i].Armor}, Attack: {prototype.characters[i].Attack}");
        }
        for(int i = 0; i < prototype.enemies.Count; i++)
        {
            Console.WriteLine($"Enemy {i+1}: {prototype.enemies[i].Name}, Health: {prototype.enemies[i].Health}, Armor: {prototype.enemies[i].Armor}, Attack: {prototype.enemies[i].Attack}");
        }
        singleton.characters = prototype.characters;
        singleton.enemies = prototype.enemies;
        singleton.Singletons("hero");
        singleton.Singletons("enemy");
        for (int i = 0; i < singleton.characters.Count; i++)
        {
            Console.WriteLine($"Character {i+1}: {singleton.characters[i].Name}, Health: {singleton.characters[i].Health}, Armor: {singleton.characters[i].Armor}, Attack: {singleton.characters[i].Attack}");
        }
        for(int i = 0; i < singleton.enemies.Count; i++)
        {
            Console.WriteLine($"Enemy {i+1}: {singleton.enemies[i].Name}, Health: {singleton.enemies[i].Health}, Armor: {singleton.enemies[i].Armor}, Attack: {singleton.enemies[i].Attack}");
        } 
        //singleton.Singletons("character");
        CoreTests coreTests = new CoreTests();
        coreTests.GameMock_TracksMethodCalls();*/
        /*Header header = new Header();
        Paragraph paragraph = new Paragraph("content");
        Element2 element2 = new Element2(); 
        Visitor visitor = new Visitor();
        ConcreteElement concreteElement = new ConcreteElement();
        header.Content = "Header Content";
        element2.name = "Element2 Name";
        visitor.visit_header(header);
        visitor.visit_paragraph(paragraph);
        visitor.visit_element2(element2);
        concreteElement.choosing_method(header);*/
    }
}
