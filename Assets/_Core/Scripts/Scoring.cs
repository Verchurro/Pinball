using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
   public TextMeshProUGUI scoreText;
    
    int score = 0;
    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }

    public void AddPoint()
    {
       
    }
}
