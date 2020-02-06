using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnerScript2 : MonoBehaviour
{


    //prefab 2
    public Transform transform2;
    public GameObject _spawnPrefab2;

    void Awake()
    {

        StartCoroutine(WaitingTime2());

    }

    IEnumerator WaitingTime2()
    {
        yield return new WaitForSeconds(5);
        Instantiate(_spawnPrefab2, transform2);
        yield return new WaitForSeconds(3);
        StartCoroutine(WaitingTime2());

    }

}