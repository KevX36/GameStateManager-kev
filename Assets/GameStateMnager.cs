using UnityEngine;

public class GameStateMnager : MonoBehaviour
{
    public enum GameState
    {
        
        MainMenu,
        Paused,
        GamePlay




    }
    
    public GameState currentState { get; private set; }
    public GameState lastState { get; private set; } 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SetState(GameState state)
    {
        if (currentState == state) return;
        lastState = currentState;
        currentState = state;
        OnStateChange(currentState);


    }
    
    private void OnStateChange(GameState newState)
    {
        switch (newState)
        {
            case GameState.MainMenu:

                



                break;


            case GameState.GamePlay:

                



                break;



            case GameState.Paused:


                


                break;




            



        }
    }

    // Update is called once per frame
    
    public void OnPause()
    {
        if (currentState == GameState.GamePlay)
        {
            SetState(GameState.Paused);
        }
        else if (currentState == GameState.Paused)
        {
            SetState(GameState.GamePlay);
        }
        
    }
    
    public void ReturnToMainMenu()
    {
        SetState(GameState.MainMenu);
    }
    public void StartGame()
    {
        SetState(GameState.GamePlay);
    }
}
