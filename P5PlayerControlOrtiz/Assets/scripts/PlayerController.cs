using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        // Move the vehicle foward  
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
