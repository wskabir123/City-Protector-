using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        if(ScoringSystem.theScore < -5)
        {
            SceneManager.LoadScene(0);
        }
    }

  
        void Update()
    {
    }


}
