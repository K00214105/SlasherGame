using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnTriggerLoadScener : MonoBehaviour
{
    
    public string levelToLoad;

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "Play")
        {
            SceneManager.LoadScene("SlasherGame");

        }

        if (other.gameObject.tag == "Instructions")
        {
           
            SceneManager.LoadScene("Instructions");
           
        }

        if (other.gameObject.tag == "ExitScreen")
        {
            SceneManager.LoadScene("ExitScreen");
            

        }

        if (other.gameObject.tag == "MainMenu")
        {
            SceneManager.LoadScene("Start");

        }

        if (other.gameObject.tag == "Exit")
        {
            
            Application.Quit();

        }


    }

	
}
