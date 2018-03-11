using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour {

    public GameObject[] groundPrefab;
    public GameObject obstaclePrefab;

    private Transform player;

    private float posZ = 0f;
    private float groundLength = 100f;
    private float startingGrounds = 2f;

    private List<GameObject> activeGround = new List<GameObject>();

    void Start()
    {
        // transform of object tagged 'player'
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // spawn 5 grounds to start
        for (int i = 0; i < startingGrounds; i++)
        {
            Spawn();
        }  
    }

    private void Update()
    {
        // spawn new ground and delete non-active grounds
        if (player.position.z - 75 > (posZ - startingGrounds * groundLength))
        {
            Spawn();
            Delete();
        }
    }

    void Spawn()
    {
        // create ground
        GameObject spawn = Instantiate(groundPrefab[0]) as GameObject;
        // set GroundManager as parent
        spawn.transform.SetParent(transform);
        spawn.transform.position = Vector3.forward * posZ;
        posZ += groundLength;
        // add to list
        activeGround.Add(spawn);      
    }

    void Delete()
    {
        // destory object at index 0; remove from list
        Destroy(activeGround[0]);
        activeGround.RemoveAt(0);
    }
}
