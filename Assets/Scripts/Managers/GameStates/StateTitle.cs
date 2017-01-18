using UnityEngine.SceneManagement;

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
        SceneManager.LoadSceneAsync(SceneExt.E2S(Scenes.Title), LoadSceneMode.Additive);

        // for Debug
        owner.ChangeState(GameState.Ready);
      }
    }
  }
}
