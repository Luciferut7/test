using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking_Station : MonoBehaviour
{
   
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                // Implement cooking logic
                Debug.Log("Cooking!");
            }
        } 
}

