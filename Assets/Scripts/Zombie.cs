using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public Vector3 initV;
    //public bool active;
    [SerializeField] public float speed = 3.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initV = rb.linearVelocity;
    }

    // Update is called once per frame
    public void Update()
    {
        rb.angularVelocity = 0;

        if(player != null)
        {
            rb.linearVelocity = (player.transform.position - transform.position).normalized * speed;
        }
        else if(player == null)
        {
            rb.linearVelocity = initV;
        }
    }
}
