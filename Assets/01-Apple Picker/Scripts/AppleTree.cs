using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Balls; 
public class AppleTree : MonoBehaviour
{
    public GameObject BallsPrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections;
    
    public float secondsBetweenBallsDrops;

   
    // Start is called before the first frame update
    void Start()
    {     
          Invoke( "DropBalls", 2f ); 
    }
    void DropBalls() {                         
        var Balls = Instantiate(BallsPrefab);
        Balls.transform.position = transform.position;
        Invoke( "DropBalls", secondsBetweenBallsDrops);

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
