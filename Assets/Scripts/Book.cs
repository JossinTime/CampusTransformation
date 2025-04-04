using UnityEngine;
using Yarn.Unity;

public class Book : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    [YarnCommand ("DestroyBook")]
    public void BookBye()
    {
        Destroy (gameObject);
    }
    
}
