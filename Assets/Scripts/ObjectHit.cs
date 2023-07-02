using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Collision other = who is this other thing colliding with me?
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Bumped into a wall.");
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            gameObject.tag = "Hit";
        }
    }

}
