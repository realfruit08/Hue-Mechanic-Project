using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 1f;
    public float startingHealth = 1f;
    public float spiked = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingHealth = Health;
    }
    public void Damaged(float spiked)
    {
        startingHealth -= spiked;
        if (startingHealth <= 0)
        {
            Debug.Log("dies");
            SceneManager.LoadScene("Scenes/SampleScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
