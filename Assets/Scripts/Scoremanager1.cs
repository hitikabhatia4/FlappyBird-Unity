using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoremanager1 : MonoBehaviour
{
    public static Scoremanager1 instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score +=coinValue;
        text.text = "X" + score.ToString();
        PlayerPrefs.SetString("Score", (score.ToString("0")));

    }
}
