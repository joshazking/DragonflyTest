using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public int points = 0;

    private void OnGUI() 
    {
        GUI.Label(new Rect(10,10,1000,200), "Score : " + points);    
    }

}
