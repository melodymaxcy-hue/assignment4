using UnityEngine;

public class FunnyBallCollision : MonoBehaviour
{   
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<RigidBody>();
        
    }

    // Update is called once per frame
    void Update()
    { 
    
    }
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("FunnyBall collided with: " + collision.gameObject.name);
    }
    
     void Launch(Vector3 force)
    {
        rb.AddForce(force);
    }
        
    
}
