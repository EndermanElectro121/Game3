public class Database
{
    public void writing_of_all_database_of_class_Game_into_txt_file(string path, Game game)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine();
            writer.WriteLine("Characters in Database:");
            foreach (Character character in game.characters)
            {
                writer.WriteLine($"Character Name: {character.Name}, Health: {character.Health}, Attack: {character.Attack}, Armor: {character.Armor}");
            }
            writer.WriteLine();
            writer.WriteLine("Enemies in Database:");
            foreach (Enemy enemy in game.enemies)
            {
                writer.WriteLine($"Enemy Name: {enemy.Name}, Health: {enemy.Health}, Attack: {enemy.Attack}, Armor: {enemy.Armor}, Rage: {enemy.Rage}");
            }
        }    
    }
    public void reading_of_all_database_of_class_Game_from_txt_file(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}    

