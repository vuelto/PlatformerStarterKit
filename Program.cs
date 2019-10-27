using System;

namespace PlatformerGame 
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PlatformerStarterKit())
                game.Run();
        }
    }
}
