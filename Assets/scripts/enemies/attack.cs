using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject obj;
    Vector2 vec2;
    public float kd;
    float nextspawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextspawn)
        {
            nextspawn = Time.time + kd;
            vec2 = new Vector2(transform.position.x, transform.position.y);
            GameObject bullet = Instantiate(obj, vec2, Quaternion.identity);
            Destroy(bullet, 3.5f);
        }
            
    }
}
