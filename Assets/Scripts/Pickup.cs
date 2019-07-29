using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    void Update() 
    {
        transform.Rotate(0, 0,  90 * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) 
    {

        if(other.name == "Spitfire_body")
        {
            //destroy coin and add 1 to score
            other.GetComponent<score>().points++;
            Destroy(gameObject);
        }

    }

}
