using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    public MoveCube move;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("I have hit something");
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
        else
        {
            move.enabled = true;
            
        }
        
        
    }
}
