using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        PrintINstruction();
    }
    void Update()

    {
       MovePlayer();
    }

    void PrintINstruction()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or Arrow keys to move the player");
    }

    void MovePlayer()
    {
         float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0.00f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
