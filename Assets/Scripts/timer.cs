using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public float RunEvery = 10;
    
    public bool RunOnAwake = false;
    public bool Loop = true;
    public UnityEvent OnTimerEnd;
    private void OnEnable()
    {
        if(RunOnAwake)
        {
            Invoke("Execute", 0);
        }
        if(Loop)
        {
            InvokeRepeating("Execute", RunEvery, RunEvery);
        }
        else
        {
            Invoke("Execute", RunEvery);
        }
    }
    public void Execute()
    {
        OnTimerEnd.Invoke();
    }
}
