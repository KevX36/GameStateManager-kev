using UnityEngine;

public class UIbuttonfunction : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.instance.stateMnager.StartGame();
    }
    public void Quit()
    {
        GameManager.instance.QuitGame();
    }
    public void BackToMenu()
    {
        GameManager.instance.stateMnager.ReturnToMainMenu();
    }
    public void BackToGame()
    {
        GameManager.instance.stateMnager.OnPause();
    }
}
