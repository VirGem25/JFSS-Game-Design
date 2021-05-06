using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay;

    public void EndGame()
    {
        if(gameEnded == false)
        {
            Debug.Log("GAME OVER");
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
