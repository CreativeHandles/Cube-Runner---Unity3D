using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    public GameManager gameManager;

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            gameManager.CompleteLevel();
        }
    }
}
