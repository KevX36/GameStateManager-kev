using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Start()
    {
        LoadUiScene(); 
    }
    public void LoadLevel(string level)
    {
        Debug.Log("loaded " + level);
        SceneManager.LoadScene(level);
    }
    
    public void LoadUiScene()
    {
        Debug.Log("loaded UI");
        SceneManager.LoadSceneAsync("UI scene",LoadSceneMode.Additive);
    }
    public void UnloadUiScene()
    {
        Debug.Log("unloaded UI");
        SceneManager.UnloadSceneAsync("UI scene");
    }
}
