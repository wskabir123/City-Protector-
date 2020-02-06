using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ButtonColliders : MonoBehaviour
{

   public Animator anim;

    //private void Awake()
    //{
    //    anim = GetComponent<Animator>();
    //}


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("animation is playing");
        anim.Play("Flytheplane");
        
    }

}
