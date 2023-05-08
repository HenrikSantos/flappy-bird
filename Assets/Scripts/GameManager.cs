using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    public void gameOver()
    {
        Debug.Log("Game Over");
    }

    public void increaseScore()
    {
        score++;
        Debug.Log(score);
    }
}
