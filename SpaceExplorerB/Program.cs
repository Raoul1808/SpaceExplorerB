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
        
        Assets.PreloadFont("Tiny Unicode", new [] {"TinyUnicode.ttf"});

        SceneManager.Add("Menu Scene", new MenuScene());
        SceneManager.Add("Game Scene", new GameScene());
        
        game.Run();
    }
}
