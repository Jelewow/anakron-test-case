using Anakron.Infrastructure;
using Anakron.Helpers;
using Anakron.Infrastructure.AssetManagement;
using Anakron.Infrastructure.Factory;
using Anakron.Infrastructure.Services;

namespace Anakron.StateMachine.States
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly Services _services;

        public BootstrapState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, Services services)
        {
            _stateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
            _services = services;

            RegisterServices();
        }

        public void Enter()
        {
            _sceneLoader.Load(Constants.Scenes.Init, EnterLoadLevel);
        }

        public void Exit()
        {
            
        }

        private void EnterLoadLevel()
        {
            _stateMachine.Enter<LoadLevelState, string>(Constants.Scenes.Main);
        }

        private void RegisterServices()
        {
            _services.RegisterSingle<IAssetProvider>(new AssetProvider());
            
            _services.RegisterSingle<IGameFactory>(new GameFactory(_services.Single<IAssetProvider>()));
        }
    }
}