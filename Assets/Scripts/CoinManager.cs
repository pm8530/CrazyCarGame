using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    

    

    public float coinSpeed = 5f;



    // Start is called before the first frame update

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinSpeed +=0.1f* Time.deltaTime;
        transform.Translate(Vector2.down * coinSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destory")
        {
            Destroy(gameObject);  
        }

       
    }




   


}
