using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform targetPos;
    private float speed = 0.05f;
    private bool onground;
    private Animator anim;
    private Rigidbody rb;
    public  NavMeshAgent agent;
    public PlayerController okk;

    // private ConfigurableJoint jointt;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        // jointt = GetComponent<ConfigurableJoint>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (okk == true){
            anim.SetBool("iswalk", true);
            agent.destination = targetPos.position;
        
            transform.Rotate(transform.rotation.x, Mathf.Round(transform.rotation.y), transform.rotation.z, Space.World);
        }
        else {
            anim.SetBool("iswalk", false);
            // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            agent.speed = 0f;
            agent.acceleration = 0f;
            agent.angularSpeed = 0f;

        }
        // Debug.Log(Mathf.Round(transform.rotation.y));

        // Vector3 direction = targetPos.position - transform.position;
        // transform.position = Vector3.MoveTowards(transform.position, targetPos.position, speed);
        // direction = new Vector3(direction.x, 0f, direction.z);
        // Vector3 newTarg  = new Vector3(targetPos.position.x, 0f, targetPos.position.z);
        // transform.position = Vector3.MoveTowards(transform.position, newTarg, speed);
        // transform.rotation = Quaternion.LookRotation(direction);
        
        // // transform.Translate(transform.position, direction speed);
        // // transform.Translate(Vector3.forward * 5f);
        // // jointt.targetPosition = targetPos.position;
        // // jointt.targetRotation = Quaternion.LookRotation(direction);

        // if (targetPos.position.y >= 1){
        //     onground = false;
        //     anim.SetBool("isjump", true);
        //     anim.SetBool("iswalk", false);
        //     rb.AddForce(Vector3.up);
        // }
        // // else{
            
        // //     anim.SetBool("isjump", false);
        // // }

        
    }

    // private void OnCollisionEnter(Collision collision){
    //     if (collision.gameObject.CompareTag("Ground")){
    //         onground = true;
    //         anim.SetBool("iswalk", true);
    //     }
    //     // onground = true;
    // }
}
