using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    private float propelSpeed = 0.5f;
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
        movement = new Vector3(-moveHorizontal, 0, -propelSpeed);
        rb.AddForce(movement * speed, ForceMode.VelocityChange);
    }
}
