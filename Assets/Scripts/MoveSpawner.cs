using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawner : MonoBehaviour {
    public float speed = 200f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Random rnd = new Random();
        Random.Range(30.0f, 50.0f);
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 4),transform.position.y, Mathf.PingPong(Random.Range(20.0f, 50.0f),50));
	}
}
