using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Balls;

    

public class apple : MonoBehaviour
{
    public static float     bottomY = -20f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if ( transform.position.y < bottomY ) {
             Destroy( this.gameObject );  

             ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();           // b
             // Call the public AppleMissed() method of apScript
             apScript.AppleMissed();
    }
}
}