using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    private bool isCollected = false;

    // Update is called once per frame
    void Update()
    {
        // Make our coin rotate each frame
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isCollected == true )
        {
            return; // Do Nothing 
        }

        // Check to see if the object is the player 
        if (other.gameObject.CompareTag("Player"))
        {
            isCollected = true;

            //Destroy the coin
            Destroy(this.gameObject);

            // Update our points
            GameManager.Instance.UpdateScore(1);

            // Play sound effect
            AudioManager.Instance.PlaySound("Collect Coin");
        }
    }   
}
