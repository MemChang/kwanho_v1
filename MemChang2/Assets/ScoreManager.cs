using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = "score : " + score;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void scorePlus()
    {
        scoreText.text = "score : " + (++score);
    }

    public void scoreMinus()
    {
        scoreText.text = "score : " + (--score);
    }

}
