using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int _score = 0;

    public void AddScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}
