using Anakron.Core;
using Anakron.StateMachine.States;
using UnityEngine;

namespace Anakron.Infrastructure
{
    public class Bootstrapper : MonoBehaviour, ICoroutineRunner
    {
        [SerializeField] private LoadingCurtain _loadingCurtainPrefab;
        private Game _game;

        private void Awake()
        {
            _game = new Game(this, Instantiate(_loadingCurtainPrefab));
            _game.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}