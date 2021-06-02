using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    public float restartDelay;

    public GameObject levelCompletePanel;
    public GameObject levelCompleteText;



    public void CompleteLevel()
    {
        levelCompletePanel.SetActive(true);
        levelCompleteText.SetActive(true);
    }

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
