using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexa : MonoBehaviour
{
    public float time;
    public Rigidbody2D rb;
    public float shrinkSpeed=10f;
    int m;
    void Start()
    {
       rb.rotation =Random.Range(0.0f, 360.0f);
        transform.localScale = Vector3.one * 10f;
        m = 0;
    }
    void Update()
    {
        if (m == 0)
        {
            if (transform.localScale.x <= 1.3f)
            {
                scorescript.scoreValue++;
                m = 1;
            }
        }
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x <= .5f)
        {
            Destroy(gameObject);
        }
    }
}