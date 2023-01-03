using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball, quitButton, scoreText;
    [SerializeField] Vector3 startpPos;
    public int multiplier;
    public static GameManager Instance;
    int score;
    bool canPlay;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        score = 0;
        multiplier = 1;
        Time.timeScale = 1;
        canPlay = false;
    }

    public void GameStart()
    {
        scoreText.SetActive(true);
        Instantiate(ball,startpPos,Quaternion.identity);
    }

}
