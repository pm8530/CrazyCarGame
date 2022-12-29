using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{

    public float speed = 0.8f;

    public float maxRoadSpeed = 1.5f;

    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maxRoadSpeed > speed)
        {
            speed += 0.001f * Time.deltaTime;
            offset = new Vector2(0f, Time.time * speed);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
        else
        {
            speed = maxRoadSpeed;
        }

        
    }
}
