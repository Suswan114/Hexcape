using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    public int c = 1;
    int next,m;
    float t;
    public AudioSource crash;
    public AudioSource pew;
    private void Start()
    {
        next = scorescript.scoreValue+1;
    }
    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if(touchPosition.x>0)
            {
                t = 1;
            }
            else if(touchPosition.x==0)
            {
                t = 0;
            }
            else
            {
                t =- 1;
            }    
                
            transform.RotateAround(Vector3.zero, Vector3.forward, t* Time.deltaTime * -360);
            touchPosition.z = 0f;
        }
        if (next == scorescript.scoreValue)
        {
            pew.Play();
            next++;
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Handheld.Vibrate();
        crash.Play();
        SceneManager.LoadScene("collision");
        Time.timeScale = 0;
        Destroy(gameObject);
        c = 0;
    }
}