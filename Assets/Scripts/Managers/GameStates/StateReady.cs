using Utils.StateMachine;

namespace Game
{
  public partial class GameManager
  {
    private class StateReady: State<GameManager>
    {
      public StateReady(GameManager owner) : base(owner) { /* do nothing */ }

      public override void Enter()
      {
        // for Debug
        owner.ChangeState(GameState.Playing);
      }
    }
  }
}
