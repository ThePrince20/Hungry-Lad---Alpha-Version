using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method that detects collision
    void OnTriggerEnter(Collider other)
    {
        // Destroy objects
        Destroy(gameObject);
    }
}
