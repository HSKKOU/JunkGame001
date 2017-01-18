using Utils.StateMachine;

namespace Game
{
  public partial class GameManager
  {
    private class StateTitle: State<GameManager>
    {
      public StateTitle(GameManager owner) : base(owner) { /* do nothing */ }

      public override void Enter()
      {
        // for Debug
        owner.ChangeState(GameState.Ready);
      }
    }
  }
}
