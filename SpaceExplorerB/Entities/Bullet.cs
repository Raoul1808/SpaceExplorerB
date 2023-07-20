using Brocco;
using Microsoft.Xna.Framework;

namespace SpaceExplorerB.Entities;

public class Bullet : Entity
{
    public Vector2 Velocity { get; set; }

    public Bullet()
    {
        Scale = new Vector2(2f, 5f);
    }

    public override void Update(float dt)
    {
        Position += Velocity * dt;
        if (Position.Y + BoundingBox.Height < 0)
            Dispose();
    }
}
