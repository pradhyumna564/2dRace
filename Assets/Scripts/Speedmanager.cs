using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedmanager : MonoBehaviour
{
    public static float speed = 2;
    public float maxspeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Increasespeed());
    }

    // Update is called once per frame
    private IEnumerator Increasespeed()
    {
        yield return new WaitForSeconds(5);
        if (speed < maxspeed)
        {
            speed += 0.5f;
            StartCoroutine(Increasespeed());
        }

    }
}
