using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovetoLVL1 : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("LVL1");
            // Debug.Log("True");
        }
    }
}
