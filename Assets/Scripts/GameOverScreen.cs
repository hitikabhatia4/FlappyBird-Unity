using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text ValueToUpdate;

    void Start()
    {
        ValueToUpdate.text = PlayerPrefs.GetString("Score", "0");
    }

    
}
