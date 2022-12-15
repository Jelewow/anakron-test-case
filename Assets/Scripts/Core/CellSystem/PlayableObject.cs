using System;
using UnityEngine;

namespace Anakron.Core.CellSystem
{
    public abstract class PlayableObject<TColor> : MonoBehaviour
    {
        public Coordinate Coordinate;

        [SerializeField] protected SpriteRenderer Renderer;
        
        private TColor _color;

        public TColor Color
        {
            get => _color;
            set
            {
                _color = value;
                ChangeColor(value);
            }
        }
        
        protected abstract void ChangeColor(TColor color);
    }
}