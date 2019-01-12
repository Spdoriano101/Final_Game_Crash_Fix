using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Extra using statement to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    //Designer Variables
    public string sceneToLoad;

    float currentTime = 0f;
    float startingTime = 180f;

    [SerializeField] Text countdownText;

    // Use this for initialization
    void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
   


    
        if(currentTime <= 0)
        {

            currentTime = 0;

            // load next level
            SceneManager.LoadScene(sceneToLoad);
        }






    }


    
}

