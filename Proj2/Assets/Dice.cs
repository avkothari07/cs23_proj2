using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
int number = 1;


 void OnGUI() {
     //GUI.backgroundColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
     GUI.Box(new Rect(10,10,60,50), "Move " + number);
        if (GUI.Button(new Rect(10,70,80,30), "Re-roll"))
         {
            number = Random.Range(1,7);
         }
 }
}
