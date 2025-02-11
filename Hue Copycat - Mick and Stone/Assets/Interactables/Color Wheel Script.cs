using UnityEngine;

public class ColorWheelScript : MonoBehaviour
{

    public GameObject colorWheel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            Debug.Log("colorwheel?");
            colorWheel.SetActive(true);
            Time.timeScale = 0.3f;
        }

    }
}
