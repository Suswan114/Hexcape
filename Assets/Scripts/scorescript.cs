using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    public static int c = 1;
    public static int scoreValue = 0;
    Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }
    void Update()
    {
        if(scoreValue==0)
        {
            c = 0;
        }
        score.text = "" + scoreValue;
    }
}