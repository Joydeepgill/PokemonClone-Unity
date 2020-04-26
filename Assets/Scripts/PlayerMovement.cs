using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    public Sprite playerSprite; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the user input (by the keys) 
        //Detect when left arrow key is pressed down 
        if(Input.GetKey(KeyCode.LeftArrow)) {
            //Move left 
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            //Move Right 
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            //Move up
        } else {
            //Move down
        }
    }
}
