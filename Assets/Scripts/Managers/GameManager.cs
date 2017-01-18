using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Utils.StateMachine;

namespace Game
{

  public enum GameState
  {
    Init,
    Title,
    Ready,
    Playing,
    Result,
    Num
  }
 
  public partial class GameManager : StatefulSingletonMono<GameManager, GameState>
  {

    void Awake()
    {
      Initialize();
    }


    public override GameManager Initialize()
    {
      base.Initialize();

      stateList.Add(new StateInit(this));
      stateList.Add(new StateTitle(this));
      stateList.Add(new StateReady(this));
      stateList.Add(new StatePlaying(this));
      stateList.Add(new StateResult(this));

      ChangeState(GameState.Init);

      return this;
    }
  }

}
