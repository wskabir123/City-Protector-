using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraAudioPlayer : MonoBehaviour
{


    public AudioSource _clip;




    // Start is called before the first frame update
    void Start()
    {
        _clip.GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider _AudioClipCollider)
    {
       if(_AudioClipCollider.tag == "SpawningObj")
        {
            _clip.Play();
            Handheld.Vibrate();
            
        }
    }


}

