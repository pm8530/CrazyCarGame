using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    public GameObject[] EnemyCar;
    int EnemyCarIndex;

    Vector3 enemyCarPos;

    float minX = -1.15f;
    float maxX = 1.15f;

    float timer;

    public float delyTimer = 2f;

    
    // Start is called before the first frame update
    void Start()
    {
        timer = delyTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            EnemyCarIndex = Random.Range(0, 6);

            enemyCarPos = new Vector3(Random.Range(minX, maxX), transform.position.y, transform.position.z);
            Instantiate(EnemyCar[EnemyCarIndex], enemyCarPos, transform.rotation);
            timer = delyTimer;
        }


        StartCoroutine(IncreseSpwanTime());



    }




    IEnumerator IncreseSpwanTime()
    {
        yield return new WaitForSeconds(10f);

        delyTimer -= 0.001f * Time.deltaTime;

    }



}
