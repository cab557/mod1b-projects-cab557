using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed =1f;

    public float leftandRightEdge = 10f;

    public float chanceToChangeDirection
    
    public float secondsBetweenAppleDrop

   
    // Start is called before the first frame update
    void Start()
    {     
        
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
         Vector3 pos = transform.position;      
 
         pos.x += speed * Time.deltaTime;       
 
         transform.position = pos; 
    }
}
