using Brocco;
using Brocco.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;

namespace SpaceExplorerB.Entities;

public class Player : Entity
{
    private const float Velocity = 100f;
    private const float BulletShootDelay = 1f / 6f;
    private const float BulletSpeed = 300f;

    private SoundEffect _shootSound;
    
    private float _shootTimer;
    
    public Player()
    {
        CurrentTexture = Assets.GetTexture("PlayerShip");
        _shootSound = Assets.GetSound("shoot1");
        Position = Vector2.One * 25;
    }
    
    public override void Update(float dt)
    {
        var vel = Vector2.Zero;

        if (InputManager.GetKeyDown(Keys.Left) || InputManager.GetButtonDown(Buttons.LeftThumbstickLeft))
            vel.X--;
        if (InputManager.GetKeyDown(Keys.Right) || InputManager.GetButtonDown(Buttons.LeftThumbstickRight))
            vel.X++;
        if (InputManager.GetKeyDown(Keys.Up) || InputManager.GetButtonDown(Buttons.LeftThumbstickUp))
            vel.Y--;
        if (InputManager.GetKeyDown(Keys.Down) || InputManager.GetButtonDown(Buttons.LeftThumbstickDown))
            vel.Y++;

        if ((InputManager.GetKeyDown(Keys.Space) || InputManager.GetButtonDown(Buttons.A)) && _shootTimer <= 0)
        {
            _shootTimer += BulletShootDelay;
            ShootBullet();
        }

        if (_shootTimer > 0)
            _shootTimer -= dt;

        if (vel != Vector2.Zero)
            vel.Normalize();
        Position += vel * Velocity * dt;
    }

    private void ShootBullet()
    {
        var bulletPos = Position;
        bulletPos.Y -= 5f;
        var bullet = Scene.AddToScene<Bullet>();
        bullet.Position = bulletPos;
        bullet.Velocity = new Vector2(0f, -BulletSpeed);
        _shootSound.Play();
    }
}
