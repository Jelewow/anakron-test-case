using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Anakron.Core.CellSystem
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Cell : PlayableObject<CellColor>, IInteractable
    {
        [HideInInspector] public Chip Chip;
        
        protected override void ChangeColor(CellColor color)
        {
            var nativeColor = color switch
            {
                CellColor.Black => UnityEngine.Color.black,
                CellColor.White => UnityEngine.Color.white,
                _ => UnityEngine.Color.magenta
            };

            Renderer.color = nativeColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            
        }
    }
}