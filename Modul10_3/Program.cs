namespace Modul10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            fileManager.Read();
            fileManager.Write();
            ((IMailer)fileManager).SendMail();

        }
    }
}