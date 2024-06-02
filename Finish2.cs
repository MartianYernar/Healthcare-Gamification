using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            transform.position = new Vector3(transform.position.x, 6.7f, transform.position.z);
            _2menuu();
        }
    }
    
    public void _2menuu(){
        SceneManager.LoadScene("Menu");
    }
}
