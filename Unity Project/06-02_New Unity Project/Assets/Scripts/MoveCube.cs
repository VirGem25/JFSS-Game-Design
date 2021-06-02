using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public float propelSpeed;
    private Vector3 movement;
    public Rigidbody rb;

    void FixedUpdate()
    {
        //float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector3(moveHorizontal, 0, propelSpeed);
        rb.AddForce(movement * speed, ForceMode.VelocityChange);
        if(rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
