using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    //Variable representing the speed
    public float speed = 6f; 

    //Called when registering user input
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            //Get the current position of current GameObject
            Vector3 currPosition = this.transform.position; 
            //Decrease x  
            currPosition.x--; 
            //Set the new position 
            this.currPosition = currPosition; 
        } else if (Input.GetKeyDown(KeyCode.RightArrow)){ 
            Vector3 currPosition = this.transform.position; 
            currPosition.x++; 
            this.currPosition = currPosition; 
        } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Vector3 currPosition = this.transform.position; 
            currPosition.y--; 
            this.currPosition = currPosition; 
        } else {
            Vector3 currPosition = this.transform.position; 
            currPosition.y++; 
            this.currPosition = currPosition; 
        }
    } 
}
