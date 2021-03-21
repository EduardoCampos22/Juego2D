using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int playerScore;

    // Label de la capa UI
    public Text scoreText;

    public void AddScore()
    {
        playerScore++;
        // Debug.Log("Puntos: " + playerScore);
        scoreText.text = playerScore.ToString();
    }
}
