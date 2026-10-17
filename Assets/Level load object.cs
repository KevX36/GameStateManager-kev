using UnityEngine;

public class Levelloadobject : MonoBehaviour
{
    public string levelToLoad;
    public bool LoadWithUi;
    public bool UnloadUIScene;
    public void LoadLevel()
    {
        Debug.Log("tried to load " + levelToLoad);
        GameManager.instance.levelManager.LoadLevel(levelToLoad);
        if (LoadWithUi)
        {
            GameManager.instance.levelManager.LoadUiScene();
        }
        else if (UnloadUIScene)
        {
            GameManager.instance.levelManager.UnloadUiScene();
        }
    }
    public void QuitGame()
    {
        GameManager.instance.levelManager.QuitGame();
    }
}
