using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private float speed = 35f;
    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private float forward;
    private float xax;
    private bool isGround = true;
    public bool okk = true;
    [SerializeField] private GameObject taskk;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        // anim.SetBool("IsWalk", false);
        taskk.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (okk == true){
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
                xax = 0.1f;
                transform.position += new Vector3(0f, 0f, xax);
                // transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
                transform.rotation = Quaternion.Euler(0f, 270f, 0f);
                anim.SetBool("IsWalk", true);

            }
            
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
                xax = -0.1f;
                transform.position += new Vector3(0f, 0f, xax);
                anim.SetBool("IsWalk", true);
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                forward = 0.1f;
                transform.position += new Vector3(forward, 0f, 0f);
                anim.SetBool("IsWalk", true);
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)){
                forward = -0.1f;
                transform.position += new Vector3(forward, 0f, 0f);
                anim.SetBool("IsWalk", true);
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else{
                anim.SetBool("IsWalk", false);
            }
            if (Input.GetKey(KeyCode.Space)) {
                rb.AddForce(Vector3.up * speed, ForceMode.Force);
                anim.SetBool("isJump", true);
                isGround = false;
            }
            // Debug.Log(isGround);

            if (transform.position.y < -1){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
         
    }

    void OnCollisionEnter(Collision collision){
            isGround = true;
            anim.SetBool("isJump", false);

            if (collision.gameObject.CompareTag("Enemy")){
                okk = false;
                taskk.SetActive(true);
                // anim.SetBool("iswalk", false);
            }
    }  

    
    // void OnTriggerEnter(Collider other){  // when there is no collision but still you want to interact with the gameobject
    //     if (other.gameObject.CompareTag("Respawn")){
    //         // Destroy(other.gameObject);
    //         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    //     }
    // }



}
