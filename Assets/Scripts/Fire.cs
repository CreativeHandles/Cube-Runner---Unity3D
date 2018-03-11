using UnityEngine;

public class Fire : MonoBehaviour {

    public GameObject bullet_spawn;
    public GameObject bullet;
    public float bullet_force;

	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown("space"))
        {
            // creates bullet from spawn point
            GameObject temp_bullet;
            temp_bullet = Instantiate(bullet, bullet_spawn.transform.position, bullet_spawn.transform.rotation) as GameObject;

            // get rigidbody of bullet 
            Rigidbody temp_rb;
            temp_rb = temp_bullet.GetComponent<Rigidbody>();

            // push bullet forward
            temp_rb.AddForce(transform.forward * bullet_force);

            // remove bullet aftr set timer
            Destroy(temp_bullet, 1f);
        }

	}
}
