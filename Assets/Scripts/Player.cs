using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    

    public float movespeed;

    float move;

    float minX=-1f;
    float maxX= 1f;

    private Rigidbody2D rb;

    bool currentPlatformAndroid = false;

    private void Awake()
    {
#if UNITY_ANDROID
        currentPlatformAndroid = true;




#endif





        audioManager.instance.carSound.Play();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (currentPlatformAndroid == true)
        {
            Debug.Log("android");
        }
        else
        {
            Debug.Log("Windows");
        }
       

    }
    private void Update()
    {

        if (currentPlatformAndroid == true)
        {
            //Android Code



        }
        else
        {

            //Windows Code
            move = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;

            transform.Translate(Vector3.right * move);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);

        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);

    }

    public void MoveLeft()
    {
        rb.velocity = new Vector2(-movespeed, 0f);

    }


    public void MoveRight()
    {
        rb.velocity = new Vector2(movespeed, 0f);
    }


    public void VelocityZero()
    {
        rb.velocity = Vector2.zero;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            audioManager.instance.carSound.Stop();
            Time.timeScale = 0f;

            MainMenuController.instance.gameOverPanel.SetActive(true);
           
        }


        if (collision.gameObject.tag == "Coin")
        {
            score.instance.IncreaseCoin();

            audioManager.instance.coinSound.Play();
             
            
            Destroy(collision.gameObject);

            
          
        }

    }





}
