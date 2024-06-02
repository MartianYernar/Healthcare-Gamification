using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Player")){
            transform.position = new Vector3(transform.position.x, 0.05f, transform.position.z);
            Application.Quit();
        }
    }
}
