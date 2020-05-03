using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    Vector3 tempPosition; 
    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {  
        //Control player movement 
        if(Input.GetKey(KeyCode.LeftArrow)) {
            //Get current player movement 
            tempPosition.x -= 1f; 
            transform.position = tempPosition; 
            //KeyCode maps to a physical bkey on the keyboard 
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            tempPosition.x += 1f; 
            transform.position = tempPosition; 
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            tempPosition.y += 1f; 
            transform.position = tempPosition; 
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            tempPosition.y -= 1f; 
            transform.position = tempPosition; 
        } 
    }
}