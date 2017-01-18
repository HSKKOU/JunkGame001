using Utils.StateMachine;

namespace Game
{
  public partial class GameManager
  {
    private class StateResult: State<GameManager>
    {
      public StateResult(GameManager owner) : base(owner) { /* do nothing */ }
    }
  }
}
