﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnRate = 2f;
    public GameObject hexagonPrefab;

    private int hexagonsCreated = 0;
    
    private float nextTimeToSpawn = 0f;

	
	// Update is called once per frame
	void Update () {
		if(Time.time>= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
            hexagonsCreated += 1;
        }
	}
}
