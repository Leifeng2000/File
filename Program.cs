internal class Program
{
    private static void Main(string[] args)
    {
        string sourceFolder = @"D:\New folder (7)\Data"; //File nguồn
        string sourceFilePath = @"D:\New folder (7)\Data\Source.txt";
        
        //Directory.CreateDirectory(sourceFolder);
        //File.CreateText(sourceFilePath);
        ///

        DirectoryInfo directoryInfo= new DirectoryInfo(sourceFolder);
        directoryInfo.Create();

        FileInfo fileInfo = new FileInfo(sourceFilePath);
        fileInfo.Create();
        
    }
}