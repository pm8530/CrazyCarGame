using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMovement : MonoBehaviour
{
    public float moveSpeed=5f;

    float maxSpeed = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maxSpeed > moveSpeed)
        {
            moveSpeed +=0.1f* Time.deltaTime;
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);


        }
        else
        {
            moveSpeed = maxSpeed;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Destory"))
        {
           
            Destroy(this.gameObject);
            
        }
    }

}
