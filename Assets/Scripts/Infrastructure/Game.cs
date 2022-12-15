using Anakron.Core;
using Anakron.StateMachine;

namespace Anakron.Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine StateMachine;

        public Game(ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
        {
            StateMachine = new GameStateMachine(new SceneLoader(coroutineRunner), loadingCurtain, Services.Services.Container);
        }
    }
}