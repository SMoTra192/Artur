using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class EZDA : MonoBehaviour
{
    private float PositionX = 1.5f;
    [SerializeField] private float speed = 3f;
    private Rigidbody body;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        var pose = transform.position;
        pose.x = PositionX;
        transform.position = pose;
        body = GetComponent<Rigidbody>();
        name = "Машинка";
    }
    

    // Update is called once per frame
    void Update()
    {
        var direction = Vector3.zero;
        direction.x = Input.GetAxis("Vertical");
        direction.z = Input.GetAxis("Horizontal");
        direction *= speed;
        body.AddForce(direction);
        if (Input.GetKeyDown(KeyCode.A))
        {body.AddForce(Vector3.left * speed);}
        else if (Input.GetKeyDown(KeyCode.D))
            
        {
         body.AddForce(Vector3.right * speed);   
        }
        if (Input.GetKeyDown(KeyCode.W))
        {body.AddForce(Vector3.up * speed);}
        else if (Input.GetKeyDown(KeyCode.S))
            
        {
            body.AddForce(Vector3.down * speed);   
        }
        
        //transform.Translate(direction * Time.deltaTime);

    }
}
