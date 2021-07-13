
using UnityEngine;
using UnityEngine.Experimental.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused=false;
    public GameObject pauseMenuUI;
    public AudioSource sou;
    public GameObject sound;
    public AudioSource crash;
    public AudioSource btn;
    private void Start()
    {
        if (PlayerPrefs.GetInt("MutedSound", 0) == 0)
        {
            crash.volume = 1;
            sou.volume = 1;
            btn.volume = 1;
        }
        else
        {
            sound.SetActive(true);
            sou.volume = 0;
            crash.volume = 0;
            btn.volume = 0;
        }
    }
    public void Resume()
    {
        btn.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    public void Pause()
    {
        btn.Play();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
    public void Quit()
    {
        btn.Play();
        SceneManager.LoadScene("MAinmenu");
        scorescript.scoreValue = 0;
    }
    public void Sound()
    {
        btn.Play();
        if (PlayerPrefs.GetInt("MutedSound", 0) == 0)
        {
            sound.SetActive(true);
            PlayerPrefs.SetInt("MutedSound", 1);
            sou.volume = 0;
            crash.volume = 0;
            btn.volume = 0;
        }
        else
        {
            sound.SetActive(false);
            PlayerPrefs.SetInt("MutedSound", 0);
            sou.volume = 1;
            crash.volume = 1;
            btn.volume = 1;
        }
    }   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
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