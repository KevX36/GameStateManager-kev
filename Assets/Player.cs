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
        GameManager.instance.uiManager.UpdateUI(HP, MP);
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

            rb.MovePosition(rb.position+ move3d * speed * Time.deltaTime);
        }
    }
    public void Pause()
    {
        move = Vector3.zero;
        GameManager.instance.stateMnager.OnPause();
    }
    public void updateUI()
    {
        GameManager.instance.uiManager.UpdateUI(HP, MP);
    }
    public void heal(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            HP += 10;
            updateUI();
        }

    }
    public void takeDamage(InputAction.CallbackContext context)
    { 
        if (context.performed)
        {
            HP -= 10;
            updateUI();
        }

    }
    public void RegenMana(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            MP += 5;
            updateUI();
        }

    }
    public void CastSpell(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            MP -= 5;
            updateUI();
        }

    }
}
