using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] //not sure what this does, but it works so I'm not removing it
                                        //could easily be completely useless though
public class Dice : MonoBehaviour 
{
int number = 1;
    public AudioClip playDice;
    AudioSource sourceDice;

    void Start()
    {
        sourceDice = GetComponent<AudioSource>();
    }

    void OnGUI() {
     //GUI.backgroundColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
     GUI.Box(new Rect(10,10,60,50), "Move " + number);
        if (GUI.Button(new Rect(10,70,80,30), "Re-roll"))
         {
            number = Random.Range(1,7);
            sourceDice.PlayOneShot(playDice, 0.7F);
        }
 }
}
