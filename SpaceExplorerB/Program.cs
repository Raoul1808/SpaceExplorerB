using Brocco;
using Microsoft.Xna.Framework;
using Size = System.Drawing.Size;

namespace SpaceExplorerB;

internal class Program
{
    public static void Main(string[] args)
    {
        var game = new BroccoGame(new BroccoGameSettings
        {
            CanvasSize = new Size(256, 240),
            Resolution = new Size(256, 240),
            ClearColor = Color.CornflowerBlue,
        });
        game.Run();
    }
}
