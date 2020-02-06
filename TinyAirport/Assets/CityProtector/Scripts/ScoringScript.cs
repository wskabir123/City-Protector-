using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour
{
    //the Scoring script when colliding with hands.

    public GameObject _ScoreText;
    public static int _scores = 0;
    private void Start()
    {
        TextStartfunction();
    }

    void OnTriggerEnter(Collider otherss)
    {
        if(otherss.tag == "1")
        {
            TextStartfunction();

        }
    }


    void TextStartfunction()
    {

        
        _ScoreText.GetComponent<Text>().text = "Score: " + _scores++;
        //_ScoreText.GetComponent<Text>().text = "Score: " + _scores;
        Debug.Log("the score is counting");
        


    }



}
