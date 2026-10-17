using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void LoadLevel(string level)
    {
        Debug.Log("loaded " + level);
        SceneManager.LoadScene(level);
    }
    
    
}
