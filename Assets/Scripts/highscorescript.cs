using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscorescript : MonoBehaviour
{

    public static int score;

    public static int highscore;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
    }

    void Update()
    {
        if (scorescript.scoreValue > highscore) 
        {
            highscore = scorescript.scoreValue;
            text.text = "Highscore:" + scorescript.scoreValue;
            PlayerPrefs.SetInt("highscore", highscore);
        }
        else
        {
            text.text = "" + highscore;
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score = scorescript.scoreValue;
    }

    public static void Reset()
    {
        score = 0;
    }
}