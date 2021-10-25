using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Collider2D objectCollider;
    public Collider2D anotherCollider;
    public AudioClip playBump;
    AudioSource sourceBump;
    int count=0;

    void Start()
    {
        sourceBump = GetComponent<AudioSource>();

    }
    void OnColliderEnter2D(Collider2D objectCollider)
    {
        if (objectCollider.IsTouching(anotherCollider))
        {
            sourceBump.PlayOneShot(playBump, 0.9F);
            count = count + 5;
        }
    }

    void OnGUI()
    {
        GUI.Button(new Rect(1100, 10, 150, 50), "Repair Costs: " + count);
        if (GUI.Button(new Rect(1100, 70, 80, 25), "Add Repair"))
        { // the IF is true = clicked, lets count one
            count = count + 5;
            sourceBump.PlayOneShot(playBump, 0.9F);
        }
        if (GUI.Button(new Rect(1185, 70, 90, 25), "Lose Repair"))
        { // the IF is true = clicked, lets count one
            count = count - 5;
            sourceBump.PlayOneShot(playBump, 0.9F);
        }
    }
}
