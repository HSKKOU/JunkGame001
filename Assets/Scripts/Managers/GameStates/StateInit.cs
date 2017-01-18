using Utils.StateMachine;

namespace Game
{
  public partial class GameManager
  {
    private class StateInit: State<GameManager>
    {
      public StateInit(GameManager owner) : base(owner) { /* do nothing */ }

      public override void Enter()
      {
        // for Debug
        owner.ChangeState(GameState.Title);  
      }
    }
  }
}
