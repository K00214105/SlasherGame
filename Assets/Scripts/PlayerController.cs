using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem deathParticles;
    public Text ScoreTxt;
   
    private int score;
   

    void Start()
    {

        score = 0;
        
        SetScoreText();
       
    }

   

    void Update()
    {

    }

    void FixedUpdate()
    {

    }
    //Pick ups
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            score += 1;
           
            SetScoreText();
            Instantiate(deathParticles, transform.position, Quaternion.identity);
        }
       

    }


    ////Score
    void SetScoreText()
    {
        ScoreTxt.text = "SCORE: " + score;
        if (score == 20)
        {
            SceneManager.LoadScene("ExitScreen");
        }
    }

   

}
