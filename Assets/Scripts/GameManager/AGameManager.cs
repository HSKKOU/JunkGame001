using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Utils.StateMachine;

namespace GameManager
{
  public enum GameState
  {
    Init,
    Title,
    Ready,
    Playing,
    Result,
    Finished,
    Num
  }

  public class AGameManager : StatefulSingletonMono<AGameManager, GameState>
  {

  }

}
