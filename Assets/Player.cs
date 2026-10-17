using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 move;
    public float speed = 4;
    public Rigidbody rb;
    public int HP = 100;
    public int MP = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    public void Move(InputAction.CallbackContext context)
    {
        if(GameManager.instance.stateMnager.currentState == GameStateMnager.GameState.GamePlay)
        {
            move = context.ReadValue<Vector2>();
            Debug.Log("getting movement");
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.stateMnager.currentState == GameStateMnager.GameState.GamePlay)
        {
            Vector3 move3d = new Vector3(move.x, 0, move.y);

            rb.AddForce(move3d * speed);
        }
    }
    public void Pause()
    {
        GameManager.instance.stateMnager.OnPause();
    }
    
}
