using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {

        if(other.name == "Spitfire_body")
        {
            other.GetComponent<score>().points++;
            //destroy coin and add 1 to score
            Destroy(gameObject);
        }

    }

}
