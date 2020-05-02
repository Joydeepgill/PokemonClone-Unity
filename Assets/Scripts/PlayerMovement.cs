using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //Get current position of the player 
        Vector3 position = transform.position; 

        //Control player movement 
        if(Input.GetKey(KeyCode.A)) {
            //Get current player movement 
            position.x = position.x--; 
            transform.position = position; 
            //KeyCode maps to a physical bkey on the keyboard 
        } else if (Input.GetKey(KeyCode.D)) {
            position.x++; 
        } else if (Input.GetKey(KeyCode.W)) {
            position.y++; 
        } else if (Input.GetKey(KeyCode.S)) {
            position.y--; 
        } 
    }
}