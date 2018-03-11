using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Transform[] spawnPoints;
    public Transform player;
    public GameObject enemyPrefab;

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
               GameObject spawn = Instantiate(enemyPrefab, spawnPoints[i].position, Quaternion.identity) as GameObject;
                spawn.transform.SetParent(spawnPoints[i]);
            }
        }

    }
}
