using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections;
    
    public float secondsBetweenAppleDrops;

   
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

        //Changing Direction
         if ( pos.x < -leftAndRightEdge ) {      
 
           speed = Mathf.Abs(speed); // Move ri
       } else if ( pos.x > leftAndRightEdge ) {
 
           speed = -Mathf.Abs(speed); // Move l

    }
}
    void FixedUpdate() {
        // Changing Direction Randomly is now t
        if ( Random.value < chanceToChangeDirections)
            speed *= -1; // Change direction

}
}