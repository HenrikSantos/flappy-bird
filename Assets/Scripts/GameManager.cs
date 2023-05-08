using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;

    public TextMeshProUGUI scoreText;

    public GameObject playButton;

    public GameObject gameOverButton;

    private int score;

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    private void Awake()
    {
        Time.timeScale = 0f;
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOverButton.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;

        player.enabled=true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        foreach (var item in pipes)
        {
            Destroy(item.gameObject);
        }
    }

    public void gameOver()
    {
        gameOverButton.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void increaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
