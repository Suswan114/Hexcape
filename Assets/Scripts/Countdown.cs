using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    public float startTime=6;
    float currentTime;
    public Text timer;
    public GameObject panel;
    public GameObject gameOver;
    public AudioSource sou;
    public AudioSource back;
    public void skip()
    {
        sou.Play();
        if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
        {
            back.volume = 1;
        }
        else
        {
            back.volume = 0;
        }
        panel.SetActive(false);
        gameOver.SetActive(true);
    }
    public void Click()
    {
        if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
        {
            back.volume = 1;
        }
        else
        {
            back.volume = 0;
        }
        panel.SetActive(false);
        gameOver.SetActive(true);
        Time.timeScale = 1;
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("MutedSound", 0) == 0)
        {
            sou.volume = 1;
        }
        else
        {
            sou.volume = 0;
        }
        back.volume =0;
        Time.timeScale = 0;
        panel.SetActive(true);
        currentTime = startTime;
    }
    private void Update()
    {
        timer.text = currentTime.ToString("0");
        if(scorescript.c==1)
        {
            if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
            {
                back.volume = 1;
            }
            else
            {
                back.volume = 0;
            }
            gameOver.SetActive(true);
            panel.SetActive(false);
        }
        if (currentTime > 0 && currentTime <= 6)
        {
            currentTime -= 1 * Time.unscaledDeltaTime;
        }
        if (currentTime <= 0)
        {
            if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
            {
                back.volume = 1;
            }
            else
            {
                back.volume = 0;
            }
            gameOver.SetActive(true);
            panel.SetActive(false);
            Time.timeScale = 1;
            currentTime = 10;
        }
    }
}
