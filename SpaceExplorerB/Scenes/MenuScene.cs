using Brocco;
using Brocco.Menu;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceExplorerB.Scenes;

public class MenuScene : Scene
{
    private MenuObject _mainMenu;
    
    public override void Load()
    {
        var font = Assets.GetFontSystem("Tiny Unicode");
        _mainMenu = MenuBuilder.CreateMenu(font, new Vector2(200, 150), fontSize: 48f)
            .AddButton("NEW GAME", sender => {SceneManager.Change("Game Scene");})
            .AddButton("SETTINGS")
            .AddButton("EXIT")
            .Build();
    }

    public override void Update(float dt)
    {
        _mainMenu.Update();
    }

    public override void ScreenRender(SpriteBatch spriteBatch)
    {
        _mainMenu.Render(spriteBatch);
    }
}
