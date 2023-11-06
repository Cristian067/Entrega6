using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ballsArray;
    private int ballIndex;

    private float spawnRangeX = 13f;
    private float spawnPosZ = 0f;
    private float spawnPosY = 30f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 2f;





    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomBalls", startDelay, spawnInterval);



    }

    // Update is called once per frame
    void Update()
    {





    }

    private void SpawnRandomBalls()
    {

        ballIndex = Random.Range(0, ballsArray.Length);

        Instantiate(ballsArray[ballIndex], RandomSpawn(), Quaternion.identity);


    }

    private Vector3 RandomSpawn()
    {
        float linea = Random.Range(-spawnRangeX, spawnRangeX);

        return new Vector3(linea, spawnPosY, spawnPosZ);
    }
}
