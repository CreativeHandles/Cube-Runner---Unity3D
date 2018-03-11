using UnityEngine;

public class EndlessMovePlayer : MonoBehaviour {

    // this is a reference to the Rigibody component called "rb"
    public Rigidbody rb;
    public float forwardMove = 6000f;
    public float sideMove = 120f;

    // marked FixedUpdate because we are using
    // physics based calculations
    void FixedUpdate()
    {
        // add force on z-axis 
        // use Time.deltaTime to counteract different speeds 
        // on different frame rates
        rb.AddForce(0, 0, forwardMove * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            // ForceMode.VelocityChange allows sharp change in direction
            rb.AddForce(sideMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideMove * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndlessOver();
        }
    }
}
