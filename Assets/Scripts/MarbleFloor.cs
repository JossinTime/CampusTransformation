using System;
using Unity.VisualScripting;
using UnityEngine;

public class MarbleFloor : MonoBehaviour
{
    [SerializeField] public GameObject zombie;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            zombie.GetComponent<Zombie>().player = other.gameObject;
        }
        else if(other.gameObject.tag == "Zombie")
        {

        }
    }

    public void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            zombie.GetComponent<Zombie>().player = null;
        }
    }
}
