using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
   [SerializeField] public TextMeshProUGUI scoreText;
    public Text highScoreText;
    int score = 0;
    int highScore = 0;
    void Start()
    {
        scoreText.text = score.ToString() + "SCORE";
        highScoreText.text = "HIGHSCORE" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
