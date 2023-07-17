using Brocco;
using Brocco.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SpaceExplorerB.Entities;

public class Player : Entity
{
    public Player()
    {
        CurrentTexture = Assets.GetTexture("PlayerShip");
        Position = Vector2.One * 25;
    }
    
    public override void Update()
    {
        var vel = Vector2.Zero;
        const float moveSpeed = 2.5f;

        if (InputManager.GetKeyDown(Keys.Left))
            vel.X--;
        if (InputManager.GetKeyDown(Keys.Right))
            vel.X++;
        if (InputManager.GetKeyDown(Keys.Up))
            vel.Y--;
        if (InputManager.GetKeyDown(Keys.Down))
            vel.Y++;

        if (vel != Vector2.Zero)
            vel.Normalize();
        Position += vel * moveSpeed;
    }
}
