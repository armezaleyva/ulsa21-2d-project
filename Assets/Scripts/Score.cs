using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   TextMeshProUGUI txtScore;

   int currentPoints;

   void Awake()
   {
       txtScore = GetComponent<TextMeshProUGUI>();
   }

    public void AddPoints(int points)
    {
        currentPoints += points;
        txtScore.text = $"<b>Score:</b> <color=#ffff>{currentPoints} pts</color>";
    }
}
