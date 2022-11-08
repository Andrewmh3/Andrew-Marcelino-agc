using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int LeftScore;
    public int RightScore;

    public int MaxScore;
    public BallController ball;

    public void AddRightScore(int increment)
    {
        RightScore += increment;
        ball.Resetball();

        if (RightScore >= MaxScore)
        {
            Gameover();
        }
    }
    public void AddLeftScore(int increment)
    {
        LeftScore += increment;
        ball.Resetball();

        if (LeftScore >= MaxScore)
        {
            Gameover();
        }
    }

    public void Gameover()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
