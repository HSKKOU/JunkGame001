using Utils.StateMachine;

namespace Game
{
  public partial class GameManager
  {
    private class StatePlaying: State<GameManager>
    {
      public StatePlaying(GameManager owner) : base(owner) { /* do nothing */ }

      public override void Enter()
      {
        // for Debug
        owner.ChangeState(GameState.Result);
      }
    }
  }
}
