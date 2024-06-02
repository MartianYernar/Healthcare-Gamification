using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movetolvl2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("LVL2");
        }
    }
}
