using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoremanager2 : MonoBehaviour
{
    public static Scoremanager2 instance;
    public TextMeshProUGUI text;
    int score;

    GameObject[] finishObjects;
    Brid playerController;
    enemy[] enemies;

    private void OnEnable()
    {
        enemies = FindObjectsOfType<enemy>();

    }
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        finishObjects = GameObject.FindGameObjectsWithTag("ShowOnFinish");

        hideFinished();


        if (Application.loadedLevelName == "Level 1")
            playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Brid>();
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "X" + score.ToString();
    }

    void Update()
    {
        foreach (enemy enemy in enemies)
        {
            if (enemy != null)
            {
                
                showFinished();
            }
        }
    }



    //shows objects with ShowOnFinish tag
    public void showFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(true);
        }
    }

   
    //hides objects with ShowOnFinish tag
    public void hideFinished()
    {
        foreach (GameObject g in finishObjects)
        {
            g.SetActive(false);
        }
    }
}

