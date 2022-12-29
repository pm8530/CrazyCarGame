using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public static score instance;

    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI gameCurrentScore;
    public TextMeshProUGUI coinText;

    public TextMeshProUGUI highScore;

   public  float Score;
    public int gameScore;
    public  float coinscore;

   int increasescore = 1;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        coinscore = 0f;
        PlayerPrefs.SetString("currentScore", "0");
        highScore.text ="High Score: "+ PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }


    private void Update()
    {
        scoretext.text = ((int) Score).ToString();




        Score += increasescore * Time.deltaTime;
        if(Score > PlayerPrefs.GetInt("HighScore", 0))
        {
           PlayerPrefs.SetInt("HighScore",((int) Score));
            highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        }

        gameCurrentScore.text = ((int)Score).ToString();
    }


    
    public void IncreaseCoin()
    {
        Debug.Log(" coin");
        
        coinscore += increasescore ;
        coinText.text = ((int)coinscore).ToString();
    }

}
