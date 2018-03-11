using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public Text highScore;

	// Use this for initialization
	void Start ()
    {
        highScore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
	}

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }
}
