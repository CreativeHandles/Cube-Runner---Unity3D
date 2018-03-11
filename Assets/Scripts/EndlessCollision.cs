using UnityEngine;

public class EndlessCollision : MonoBehaviour {

    public EndlessMovePlayer movement; // reference to player movement

    private void OnCollisionEnter(Collision collision)
    {
        // checks if object collided contains tag "Obstacle"
        if (collision.collider.tag == "Obstacle" || collision.collider.tag == "Enemy")
        {
            movement.enabled = false; // stops movement
            FindObjectOfType<GameManager>().EndlessOver();
        }
    }
}
