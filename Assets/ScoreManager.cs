using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameObject textGO = new GameObject("Score");
        //textGO.AddComponent<Text>();
        //scoreText = textGO.GetComponent<Text>();
        scoreText.text = "Test : " + score.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 100;
        scoreText.text = "Score : " + score.ToString();
        Debug.Log(score);
    }
}
