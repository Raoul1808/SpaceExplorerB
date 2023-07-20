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
    
    public override void Update(float dt)
    {
        var vel = Vector2.Zero;
        const float moveSpeed = 2.5f;

        if (InputManager.GetKeyDown(Keys.Left) || InputManager.GetButtonDown(Buttons.LeftThumbstickLeft))
            vel.X--;
        if (InputManager.GetKeyDown(Keys.Right) || InputManager.GetButtonDown(Buttons.LeftThumbstickRight))
            vel.X++;
        if (InputManager.GetKeyDown(Keys.Up) || InputManager.GetButtonDown(Buttons.LeftThumbstickUp))
            vel.Y--;
        if (InputManager.GetKeyDown(Keys.Down) || InputManager.GetButtonDown(Buttons.LeftThumbstickDown))
            vel.Y++;

        if (vel != Vector2.Zero)
            vel.Normalize();
        Position += vel * moveSpeed;
    }
}
