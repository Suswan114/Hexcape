using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionmenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static int p = 0;
    public GameObject MenuUI;
    public AudioSource back;
    public AudioSource sou;
    public GameObject music;
    public GameObject sound;
    public void Resume()
    {
        sou.Play();
        MenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        SceneManager.LoadScene("game");
        Time.timeScale = 0;
    }
    public void Pause()
    {
        sou.Play();
        MenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
    public void Restart()
    {
        sou.Play();
        MenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
        scorescript.scoreValue = 0;
        SceneManager.LoadScene("game");
        Time.timeScale = 0;
        p++;
    }
    public void Quit()
    {
        sou.Play();
        scorescript.scoreValue = 0;
        p++;
        SceneManager.LoadScene("MAinmenu");
    }
    public void Music()
    {
        sou.Play();
        if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
        {
            music.SetActive(true);
            PlayerPrefs.SetInt("MutedBackground", 1);
            back.volume = 0;
        }
        else
        {
            music.SetActive(false);
            PlayerPrefs.SetInt("MutedBackground", 0);
            back.volume = 1;
        }
    }
    public void Sound()
    {
        sou.Play();
        if (PlayerPrefs.GetInt("MutedSound", 0) == 0)
        {
            sound.SetActive(true);
            PlayerPrefs.SetInt("MutedSound", 1);
            sou.volume = 0;
        }
        else
        {
            sound.SetActive(false);
            PlayerPrefs.SetInt("MutedSound", 0);
            sou.volume = 1;
        }
    }
    private void Start()
    {
        if (PlayerPrefs.GetInt("MutedBackground", 0) == 0)
        {
            back.volume = 1;
        }
        else
        {
            music.SetActive(true);
            back.volume = 0;
        }
        if (PlayerPrefs.GetInt("MutedSound", 0) == 0)
        {
            sou.volume = 1;
        }
        else
        {
            sound.SetActive(true);
            sou.volume = 0;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}
