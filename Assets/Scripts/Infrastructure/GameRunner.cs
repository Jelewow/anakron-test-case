using System;
using UnityEngine;

namespace Anakron.Infrastructure
{
    public class GameRunner : MonoBehaviour
    {
        [SerializeField] private Bootstrapper _bootstrapperPrefab;

        private void Awake()
        {
            var bootstrapper = FindObjectOfType<Bootstrapper>();

            if (bootstrapper != null)
            {
                return;
            }

            Instantiate(_bootstrapperPrefab);
        }
    }
}