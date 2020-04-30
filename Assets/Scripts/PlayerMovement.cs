using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    //Variable representing the speed
    public float speed = 6f; 
    //enables physical behaivour to the sprite 
    public RigidBody2D rigidBody; 

    Vector2 movement; 
    //Called when registering user input
    void Update()
    {
        
    } 
}
