﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject Scoretext;
    public static int theScore;


    void Update()
    {
        Scoretext.GetComponent<Text>().text = "Score: " + theScore;
    }
}
