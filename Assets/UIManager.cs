using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject HUD;
    public void ShowPauseScreen()
    {
        HideAllUI();
        Time.timeScale = 0.0f;
        pauseScreen.SetActive(true);
         
    }
    
    public void returnToGame()
    {
        HideAllUI();
        Time.timeScale = 1.0f;
        
        HUD.SetActive(true);
    }
    public void HideAllUI()
    {
        HUD.SetActive(false);
        pauseScreen.SetActive(false);
    }
}
