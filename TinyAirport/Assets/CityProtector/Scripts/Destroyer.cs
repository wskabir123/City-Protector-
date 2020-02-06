using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    //public float lifetime = 3f;
    //void Update()
    //{
    //if(lifetime > 0)
    //{
    //    lifetime -= Time.deltaTime;
    //    if(lifetime <= 0)
    //    {
    //        destruction();
    //    }
    //    if(this.transform.position.y <= -40)
    //    {
    //        destruction();
    //    }

    //}


    //}
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Sphere")
        {

            Destroy(coll.gameObject);
           
        }
    }


}
