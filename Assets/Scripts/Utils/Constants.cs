namespace Game
{

  #region Scene

  public enum Scenes
  {
    Title,
    Game,
    Result,
    Num
  }

  public static class SceneExt
  {

    private static string[] sceneStr = {
      "Title",
      "Game",
      "Result"
    };

    public static string E2S(Scenes scene)
    {
      int sceneNum = (int)scene;
      if (sceneNum >= (int)Scenes.Num)
      {
        return "";
      }

      return sceneStr[sceneNum];
    }

  }

  #endregion

}


namespace Constant
{
  
}