using Brocco;
using Brocco.Basic;
using Microsoft.Xna.Framework;
using SpaceExplorerB.Scenes;

namespace SpaceExplorerB;

internal class Program
{
    public static void Main(string[] args)
    {
        var game = new BroccoGame(new BroccoGameSettings
        {
            CanvasSize = new Size(256, 240),
            ClearColor = Color.Black,
        });
        
        SceneManager.Add("Game Scene", new GameScene());
        
        game.Run();
    }
}
