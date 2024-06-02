using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform playerPos;
    
    private float smoothTime = 0.25f;
    private Vector3 _offset;
    private Vector3 _currentVel = Vector3.zero;

    void Awake()
    {
        // Vector3 VectargetPos = new Vector3(targetPos);
        _offset = transform.position - playerPos.position;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPos = playerPos.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVel, smoothTime);
    }

    public void Reset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         
    }

    
}
