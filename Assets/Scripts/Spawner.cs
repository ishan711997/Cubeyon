﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    //for access position of plyr
    public GameObject Player;
    // //////////////////////////
    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnLeastWait;
    public float spawnMostWait;    
    public int startWait;
    public bool stop;
    
    int randEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    void Update()
    {
        spawnWait = Random.Range (spawnLeastWait,spawnMostWait);

        // move respectively to player on z axis only
        transform.position = new Vector3(0,0,Player.transform.position.z + 200);
        // /////////////////////////////////////////
    }
    

    IEnumerator waitSpawner(){
        yield return new WaitForSeconds (startWait);

        while (!stop){
            randEnemy = Random.Range(0, 8);

            Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x), 1, Random.Range (-spawnValues.z, spawnValues.z));

            Instantiate (enemies[randEnemy], spawnPosition + transform.TransformPoint(0,0,0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }



}
