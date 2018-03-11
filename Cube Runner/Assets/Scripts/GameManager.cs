using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject completeText;
    bool gameEnd = false;
    float delay = 1f;

    public void CompleteLevel()
    {
        completeText.SetActive(true);
    }

    public void GameOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Invoke("Restart", delay);
        }
    }

    public void EndlessOver()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            SceneManager.LoadScene("Menu");
        }
    }

    void Restart()
    {
        // loads whatever scene is currently active; pulls name of scene and LoadScene takes the parameter
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
