 using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class ArrowKeys : MonoBehaviour {
     
     float speed = 1.2f;
     
     void Update() {
        var movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += movement * speed * Time.deltaTime;
     }
 }