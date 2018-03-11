using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void StartEndless() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartLevels()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
