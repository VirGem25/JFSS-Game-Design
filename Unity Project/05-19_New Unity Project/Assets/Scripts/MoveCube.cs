using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public float propelSpeed;
    private Vector3 movement;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
