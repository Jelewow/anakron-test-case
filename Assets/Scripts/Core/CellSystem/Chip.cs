using UnityEngine;

namespace Anakron.Core.CellSystem
{
    public class Chip : PlayableObject<PlayerColor>
    {
        protected override void ChangeColor(PlayerColor color)
        {
            var nativeColor = color switch
            {
                PlayerColor.Blue => UnityEngine.Color.blue,
                PlayerColor.Green => UnityEngine.Color.green,
                PlayerColor.Purple => new Color(128, 0, 128),
                PlayerColor.Red => UnityEngine.Color.red,
                _ => UnityEngine.Color.magenta
            };

            Renderer.color = nativeColor;
        }
    }
}