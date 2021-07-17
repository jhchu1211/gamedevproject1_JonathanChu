
using UnityEngine;

public class healthPickUp : MonoBehaviour
{
    playerHealth playerhealth;

    public float healthAmount;

    void Awake()
    {
        playerhealth = FindObjectOfType<playerHealth>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerHealth playerHealth = other.gameObject.GetComponent<playerHealth>();
            playerHealth.addHealth(healthAmount);
            Destroy(gameObject);
        }
    }

}

