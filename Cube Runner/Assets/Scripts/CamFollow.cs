using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update ()
    {
        // position of camera is set to position of player including offset
        transform.position = player.position + offset;    	
	}
}
