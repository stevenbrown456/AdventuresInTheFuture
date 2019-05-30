using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour{

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Reset the score
        PlayerPrefs.DeleteKey("score");

        // Reset the lives
        PlayerPrefs.DeleteKey("lives");


    }



}
