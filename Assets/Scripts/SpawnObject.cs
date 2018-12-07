using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject objectPrefab;
    public float spawnThreshold = 0.5f;
    public int frequency = 0;
    public FFTWindow fftWindow;
    public float debug;
    float nextSpawnTime;
    GameObject clone;
    float delay;
    private float[] samples = new float[1024];
 

	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
        AudioListener.GetSpectrumData(samples, 0, fftWindow);
        debug = samples[frequency];
        
        if (samples[frequency] > spawnThreshold)
        {
           Invoke("respawn",0.2f);
           
            
        }  
	}

    void respawn()
    {
        clone = Instantiate(objectPrefab, transform.position, transform.rotation);
    }

 

    
}
