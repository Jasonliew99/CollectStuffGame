using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public int bananaChance = 50;

    public GameObject watercupprefab;
    public GameObject bananaprefab;

    public float spawnInterval = 1f;

    public Vector2 MinMaxPos;

    public bool isSpawning = false;
    public bool isTimesUp = false;

    public float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnInterval;  
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimesUp)
            return;


        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }

        else
        {
            // we should roll dice to see if we spawn banana
            int randomNumber = Random.Range(1, 100);

            float randomXposition = Random.Range(MinMaxPos.x, MinMaxPos.y);

            Vector3 randomizedPosition = new Vector3(randomXposition, transform.position.y, transform.position.z);

            if (randomNumber > bananaChance)
                GameObject.Instantiate(watercupprefab, randomizedPosition, transform.rotation);
            else
                GameObject.Instantiate(bananaprefab, randomizedPosition, transform.rotation);

            spawnTimer = spawnInterval;
        }
    }
}
