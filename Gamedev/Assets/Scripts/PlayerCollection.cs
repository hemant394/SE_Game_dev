using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    // Start is called before the first frame update
    public int points = 0;
   
    private void OnGUI()
    {
        GUI.Label(new Rect(20,20,200,40),"Score : "+points);
    }
}
