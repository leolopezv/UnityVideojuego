using System;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    
    public void AddScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
