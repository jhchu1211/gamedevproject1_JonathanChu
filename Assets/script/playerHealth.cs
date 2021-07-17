using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

    public float fullHealth;
    public GameObject deathFX;

    private float currentHealth;
    private playerController controlMovement;

    // HUD Variables
    public Slider healthSlider;


    // Use this for initialization
    void Start()
    {
        currentHealth = fullHealth;
        controlMovement = GetComponent<playerController>();

        // HUD Initialization
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            makeDead();
        }
    }

    public void addHealth(float health)
    {
        currentHealth += health;
        if (currentHealth > fullHealth) currentHealth = fullHealth;
        healthSlider.value = currentHealth;

    }

    //creating a function for when we die, either by damage or immediate or instant death)
    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
