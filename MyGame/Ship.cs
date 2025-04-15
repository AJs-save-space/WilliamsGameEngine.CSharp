using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace MyGame
{
    public class Ship : GameObject
    {
        private readonly Sprite _sprite = new Sprite();
        // Creates our ship

        public Ship()
        {
            _sprite.Texture = Game.GetTexture("Resources/ship.png");
            _sprite.Position = new Vector2f(100, 100);
        }
        // Draws our ship
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
        }
        // Updates our ship every frame
        public override void Update(Time elapsed)
        {
            // Do nothing just yet
        }
    }
}
