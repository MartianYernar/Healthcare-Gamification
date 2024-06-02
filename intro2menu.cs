using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro2menu : MonoBehaviour
{
    public void PlayB(){
        SceneManager.LoadScene("Menu");
    }

    public void QuitB(){
        Application.Quit();
    }
}
