using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    public Transform[] spawnPoints;
    public Transform player;
    public GameObject obstaclePrefab;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // random index number between 0 and spawn points made in Unity
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // create obstacle while randomIndex is not at end of loop
            if (randomIndex != i)
            {
               GameObject spawn = Instantiate(obstaclePrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
               spawn.transform.SetParent(spawnPoints[i]);
            }
        }
    }

    public void Update()
    {
        if (player.position.z > transform.position.z)
        {

        }
    }
}
