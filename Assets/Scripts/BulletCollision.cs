using UnityEngine;

public class BulletCollision : MonoBehaviour {

    public GameObject bullet;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(bullet);
        }

        if (collision.collider.tag == "Obstacle")
        {
            Destroy(bullet);
        }
    }
}
