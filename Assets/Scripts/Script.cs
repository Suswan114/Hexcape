using UnityEngine;
using UnityEngine.SceneManagement;
public class Script : MonoBehaviour
{
    public static int p;
    public GameObject counter;
    public GameObject music;
    public GameObject sound;
    public AudioSource back;
    public AudioSource sou;
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
    public void Rate()
    {
        sou.Play();
        Application.OpenURL("market://details?id=com.ANTICLOCK.Hexcape");
    }
    public void PlayGame()
    {
        sou.Play();
        SceneManager.LoadScene("game");
        Time.timeScale = 0;
    }
    public void Quit()
    {
        sou.Play();
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Achivements()
    {
         sou.Play();
    }
    public void Leaderboard()
    {
        sou.Play();
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
}