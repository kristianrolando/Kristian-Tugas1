using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }


    public void ScoreIncrement()
    {
        this.score += 5;
        scoreText.text = this.score.ToString();
    }
}
