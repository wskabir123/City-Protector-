using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnerScript : MonoBehaviour
{
    //prefab 1
    public Transform transform1;
    public GameObject _spawnPrefab1;
    public float beat = 60/130f;
    public float timer;


    void Awake()
    {

        StartCoroutine(WaitingTime());

    }

    

   IEnumerator WaitingTime()
    {

        //temporary Code
        if (timer > beat)
        {

            //yield return new WaitForSeconds(1);
            Instantiate(_spawnPrefab1, transform1 );
            timer -= beat;
        }

        //ends here
       yield return new WaitForSeconds(4);
        StartCoroutine(WaitingTime());

    }

    private void Update()
    {
        timer += Time.deltaTime;
    }
}
