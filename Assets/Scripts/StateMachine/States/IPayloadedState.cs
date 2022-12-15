namespace Anakron.StateMachine.States
{
    public interface IPayloadedState<TPayload> : IExitableState
    {
        public void Enter(TPayload sceneName);
    }
}