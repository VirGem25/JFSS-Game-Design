using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("I have hit something");
        }
        
        
    }
}
