using UnityEngine;
using System.Collections;

public class FrequencyTresholdSpawner : MonoBehaviour {

	
	public GameObject objectPrefab;
	//treshold
	public float spawnThreshold = 0.05f;
	//Frequency
	public int frequency;
	//Window
	public FFTWindow fftWindow;
	
	GameObject clone;
	
	
	private float[] samples = new float[4096]; //MUST BE A POWER OF TWO
	
	void Start()
	{
		
	}
	
	// Update is called once per frame
		void Update () {
        AudioListener.GetSpectrumData(samples, 0, fftWindow);
        
        
        if (samples[frequency] > spawnThreshold)
        {
            clone = Instantiate(objectPrefab, new Vector3(Random.Range(-1.0f, 5.0f), 0, 0), Quaternion.identity);
            
        }else
			clone = null;



        
	}
	
	
}


