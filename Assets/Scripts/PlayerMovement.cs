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
        Debug.Log("update the player movement!");
        //Get current position of the player 
        Vector3 position = transform.position; 
        //Control player movement 
        if(Input.GetKey(KeyCode.LeftArrow)) {
            //Get current player movement 
            position.x = position.x--; 
            transform.position = position; 
            //KeyCode maps to a physical bkey on the keyboard 
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            position.x++; 
        } else if (Input.GetKey(KeyCode.UpArrow)) {
            position.y++; 
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            position.y--; 
        } 
    }
}