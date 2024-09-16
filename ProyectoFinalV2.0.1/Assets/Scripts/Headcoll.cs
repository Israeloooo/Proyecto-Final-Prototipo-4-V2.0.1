using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headcoll : MonoBehaviour
{

    public PlayerMovement PlayerMovement;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
         PlayerMovement.CompareGround = false;
    }

    
}
