using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            transform.position = new Vector3(transform.position.x, 6.7f, transform.position.z);
            _2menu();
        }
        
    }

    public void _2menu (){
        SceneManager.LoadScene("Menu");
    }
}
