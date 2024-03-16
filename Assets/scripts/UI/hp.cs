using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class hp : MonoBehaviour
{
    public int health = 4;
    public GameObject heart4;
    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health = GameObject.Find("player").GetComponent<playerfightmove>().hp;
        healtho();
    }
    void healtho()
    {
        if (health == 4)
        {
            heart4.SetActive(true);
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (health == 3)
        {
            heart4.SetActive(false);
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (health == 2)
        {
            heart4.SetActive(false);
            heart3.SetActive(false);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (health == 1)
        {
            heart4.SetActive(false);
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(true);
        }


    }
}
