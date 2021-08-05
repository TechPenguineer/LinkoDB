using LinkoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.Json;

public class linko
{
    public static string appdataEnv = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    public static string database_folder = $"{appdataEnv}\\linko\\data";
    private static void createDataFolder()
    {
        if (!Directory.Exists(database_folder))
        {
            Directory.CreateDirectory(database_folder);
        }
    }
    public static void CreateData(CodeSpace filepath)
    {

    }
    public static void CreateFromSchema(Schema schema)
    {
        createDataFolder();
        var json = JsonSerializer.Serialize(schema);
        Console.WriteLine(json);
        //if(File.Exists($"{database_folder}\\{json.}")
    
    }

}

