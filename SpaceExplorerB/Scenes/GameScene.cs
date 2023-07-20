using System;
using Brocco;
using SpaceExplorerB.Entities;

namespace SpaceExplorerB.Scenes;

public class GameScene : Scene
{
    public override void Load()
    {
        var p = AddToScene<Player>();
        Console.WriteLine("Added player with ID: " + p.Id);
    }
}
