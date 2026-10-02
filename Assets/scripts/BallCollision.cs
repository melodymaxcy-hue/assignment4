using UnityEngine;

public class BallCollision : MonoBehaviour
{
    [SerializeField] private int ballValue = 1;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent <Rigidbody>();
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (CompareTag("Basket_03"))
        { 
            Destroy(gameObject);
        }


    }

    public void AddToScore()
    {
        Debug.Log("You got ball + ballValue");
    }

    public void Launch(Vector3 force)
    {
        rb.AddForce(force);
    }
    // Update is called once per frame
}
