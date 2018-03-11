using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreKeeper;

	// Update is called once per frame
	void Update () {
        // set text to position of player
        // makes position into string so that it can be displayed
        // add "0" on parameters so it displays whole 
        scoreKeeper.text = player.position.z.ToString("0");

        if (player.position.z > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", player.position.z);
        }
    }
}
