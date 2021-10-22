using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
int number = 1;

 
 void OnGUI() {

     GUI.Button(new Rect(10,10,50,50), "Move " + number);
        if (GUI.Button(new Rect(10,10,80,30), "Re-roll"))
         { 
            number = Random.Range(1,7);
         }
 }
}