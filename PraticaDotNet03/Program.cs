var path = @"C:\Workspace\GFT-Start3-DotNet\PraticaDotNet03\Config";

using var fsw = new FileSystemWatcher(path);

fsw.Created += onCreated;
fsw.Created += onRenamed;
fsw.Created += onDeleted;

void onCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine( $"Foi criado um arquivo {e.Name}!" );
}


void onRenamed(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"O arquivo {e.Name} foi alterado para {e.Name}!");
}


void onDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"O arquivo {e.Name} foi deletado!");
}


fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("Digite [ENTER] para finalizar...");
Console.ReadLine();