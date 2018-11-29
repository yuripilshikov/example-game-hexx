using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexxagon : MonoBehaviour {

    public Rigidbody2D rb;
    public GameObject spawner;

    public float shrinkSpeed = 1f;

	// Use this for initialization
	void Start () {
        //rb.rotation = Random.Range(0f, 360f);

        var rotation = transform.eulerAngles;
        rotation.z += Random.Range(0f, 360f);
        transform.eulerAngles = rotation;


        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        if(transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
	}
}
