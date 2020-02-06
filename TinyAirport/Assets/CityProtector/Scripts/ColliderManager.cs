using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColliderManager : MonoBehaviour
{
    public AudioSource _audioclip;
  


    private void Start()
    {
        _audioclip.GetComponent<AudioSource>();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        //this is if the object collides with the hands
        if (other.tag == "1")
        {

          
            //_audioclip.Play();
            //Score is being updated with each collision
            ScoringSystem.theScore += 1;

            //the game object will dissapear and the player will gain a point
            Destroy(this.gameObject);
            if(ScoringSystem.theScore > 200)
            {
                SceneManager.LoadScene(0);
                ScoringSystem.theScore = 0;
            }


        }

        //this is if the object collides with the City

        else if (other.tag == "2")
        {
            _audioclip.Play();
            //Game over Scene will be loaded
            ScoringSystem.theScore -= 1;
            if (ScoringSystem.theScore < -5)
            {
                //Time.timeScale = 1;
                SceneManager.LoadScene(0);
                ScoringSystem.theScore = 0;
            }
            StartCoroutine(WaitforAwhile());

        }


    }

    IEnumerator WaitforAwhile()
    {

        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    
        //if (ScoringSystem.theScore < -5)
        //{
        //    yield return new WaitForSeconds(3);
        //    Time.timeScale = 0; //pauses the current scene 

        //}

    }

}
