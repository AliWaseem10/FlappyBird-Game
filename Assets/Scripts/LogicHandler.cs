using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicHandler : MonoBehaviour
{
    public int score;
    public Text scoreBoard;
    public GameObject gameOverScreen;
    public GameObject startScreen;

    void Start()
    {
        Time.timeScale = 0;
    }
    public void addScore(int scoretoAdd)
    {
        score += scoretoAdd;
        scoreBoard.text = score.ToString();
    }

    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void startGame()
    {
        Time.timeScale = 1;
        startScreen.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
