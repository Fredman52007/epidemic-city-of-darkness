using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fhasefight : MonoBehaviour
{
    public int health = 4;
    public GameObject spawn;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject ui1;
    //public GameObject ui2;
   // public GameObject ui3;
    public bool phaseplaer = true;
    public bool phaseenemy = false;
    public float fighttime = 0f;
    [SerializeField] private string _sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fightend();
        phasecontrol();
    }
    public void Click()
    {
        phaseenemy = true;
        phaseplaer = false;
        health -= 1;
    }
    void fightend()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
    void phasecontrol()
    {
        if (phaseplaer == true)
        {
            ui1.SetActive(true);
            // ui2.SetActive(true);
            // ui3.SetActive(true);
            
        }
        else
        {
            ui1.SetActive(false);
            //ui2.SetActive(false);
            //ui3.SetActive(false);
        }
        if (phaseenemy == true)
        {
            spawn.SetActive(true);
            spawn2.SetActive(true);
            spawn3.SetActive(true);
            fighttime += Time.deltaTime;
        }
        else
        {
            spawn.SetActive(false);
            spawn2.SetActive(false);
            spawn3.SetActive(false);
        }
        if (fighttime >= 15f)
        {
            phaseenemy = false;
            phaseplaer = true;
            fighttime = 0;
        }
    }
}
