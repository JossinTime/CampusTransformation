using UnityEngine;

public class DoorShut : MonoBehaviour
{
    [SerializeField] public GameObject door;
    
    public void Start() 
    {
        door.SetActive(false);
    }
    
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            door.SetActive(true);
        }
    }
}
