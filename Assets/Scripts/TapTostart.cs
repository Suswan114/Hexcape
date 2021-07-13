using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapTostart : MonoBehaviour
{
    public GameObject tap;
    public void OnClick()
    {
        tap.SetActive(false);
        Time.timeScale = 1;
    }
}
