using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public TextMeshProUGUI text;
	int score;
    // Start is called before the first frame update
    void Start()
    {
        score = PersistentManagerScript.Instance.Value;
        text.text = "x" + score.ToString();

        if (instance == null){
        	instance = this;
        }

    }

    public void ChangeScore(int coinValue){
    	score += coinValue;
        PersistentManagerScript.Instance.Value = score;
    	text.text = "x" + score.ToString();
    }
}
