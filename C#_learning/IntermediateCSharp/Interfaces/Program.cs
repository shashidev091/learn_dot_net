namespace Interfaces
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(".\\log_shashi.txt"));
            dbMigrator.Migrate();

        }
    }
}