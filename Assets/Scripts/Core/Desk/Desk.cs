using System;
using UnityEngine;

namespace Anakron.Core.Desk
{
    public class Desk : MonoBehaviour
    {
        [SerializeField] private DeskSize _size;
        private DeskGenerator _generator;
        
        private void Awake()
        {
            _generator = new DeskGenerator();
        }

        public void CreateDesk()
        {
            _generator.CreateDesk(_size);
        }
    }
}