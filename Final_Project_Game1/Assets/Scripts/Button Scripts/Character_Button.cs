using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character_Button : MonoBehaviour {

    public static string characterChoice = "";

    public string sceneToLoad = "";

   

    public void SelectCharacter(string chosenCharacter)
    {

        PlayerPrefs.DeleteKey("Lives2");
        Score.ResetScore();

        characterChoice = chosenCharacter;

        SceneManager.LoadScene(sceneToLoad);

    }
}
