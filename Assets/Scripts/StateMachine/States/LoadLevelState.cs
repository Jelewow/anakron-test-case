using Anakron.Core;
using Anakron.Core.Desk;
using Anakron.Helpers;
using Anakron.Infrastructure;
using Anakron.Infrastructure.Factory;

namespace Anakron.StateMachine.States
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadingCurtain _loadingCurtain;
        private readonly IGameFactory _gameFactory;

        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain, IGameFactory gameFactory)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _loadingCurtain = loadingCurtain;
            _gameFactory = gameFactory;
        }
        
        public void Enter(string sceneName)
        {
            _loadingCurtain.Show();
            _sceneLoader.Load(sceneName, OnLoaded);
        }

        public void Exit()
        {
            _loadingCurtain.Hide();
        }

        private void OnLoaded()
        {
            InitDesk();
            
            _stateMachine.Enter<GameLoopState>();
        }

        private void InitDesk()
        {
            var desk = _gameFactory.CreateGameObject<Desk>(Constants.Resources.Desk);
            desk.CreateDesk();
        }
    }
}