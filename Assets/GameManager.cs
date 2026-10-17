using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            Debug.Log("This is now instance");
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Debug.Log("this is not instnaces");
            Destroy(this.gameObject);
        }
        if(levelManager != null)
        {
            levelManager = FindAnyObjectByType<LevelManager>();
        }
    }
    public LevelManager levelManager;
    public GameStateMnager stateMnager;
    public UIManager uiManager;
    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
