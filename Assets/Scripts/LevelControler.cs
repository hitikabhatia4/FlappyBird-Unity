using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 80f;
    [SerializeField]
    private string scenceNameToLoad;
    private float timeElapsed;
    enemy[] enemies;

    private void OnEnable()
    {
        enemies = FindObjectsOfType<enemy>();

    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        foreach (enemy enemy in enemies)
        {
            if (enemy != null)
            {
                return;
            }
            else if (timeElapsed > delayBeforeLoading)
            {
                ///SceneManager.LoadScene("Scorescreen");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }


        }
        



        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
}
