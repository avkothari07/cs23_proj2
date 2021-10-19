using UnityEngine;
using System.Collections;

 public class Clicker : MonoBehaviour
 {
     int counter=0;
     int cardint=0;
     string card = "";
     string[] card_text = new string[32] {"Uber stole your passenger: -$20",

                                "Passenger gave average tip: +$5",

                                "Passenger gave heavy tip: +$20",

                                "Passenger gave huge tip: +$50",

                                "Wrong turn, go back 5 squares",

                                "Uber stole your passenger: -$20",

                                "Crash ahead, skip a turn",

                                "Took too long, no tip",

                                "Had to stop for gas: -$40",

                                "Passenger left wallet with $10 inside",

                                "Got a speeding ticket: -$30",

                                "Flat tire, had to call AAA: -$35",

                                "Passenger left laptop in car. You pawned it for $30",

                                "Ran a stop sign and got pulled over: -$20",

                                "Oil change: -$15",

                                "Tolls: -$5",

                                "Uber stole your passenger: -$20",

                                "Passenger gave average tip: +$5",

                                "Passenger gave heavy tip: +$20",

                                "Passenger gave huge tip: +$50",

                                "Wrong turn, go back 5 squares",

                                "Uber stole your passenger: -$20",

                                "Crash ahead, skip a turn",

                                "Took too long, no tip",

                                "Had to stop for gas: -$40",

                                "Passenger left wallet with $10 inside",

                                "Got a speeding ticket: -$30",

                                "Flat tire, had to call AAA: -$35",

                                "Passenger left laptop in car. You pawned it for $30",

                                "Ran a stop sign and got pulled over: -$20",

                                "Oil change: -$15",

                                "Tolls: -$5"};

     void OnGUI()
     {
        GUI.Button(new Rect(880, 10, 200, 50), "Money: " + counter);
        if (GUI.Button(new Rect(880, 70, 80, 25), "Add Money"))
         { // the IF is true = clicked, lets count one
            counter ++;
         }
         if (GUI.Button(new Rect(980, 70, 90, 25), "Lose Money"))
          { // the IF is true = clicked, lets count one
             counter --;
          }
        if (GUI.Button(new Rect(550, 10, 300, 50), "Event Card: " + card))
        {
          card = card_text[cardint];
          cardint += 1;
          if (cardint > 31)
          {
            cardint = 0;
          }
        }
      }
 }
