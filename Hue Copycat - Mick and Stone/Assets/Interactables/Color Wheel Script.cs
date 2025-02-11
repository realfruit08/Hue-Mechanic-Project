using UnityEngine;

public class ColorWheelScript : MonoBehaviour
{

    public GameObject colorWheel;
    public Camera maincamera;

    bool isWheelActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorWheel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
    {
        colorWheel.SetActive(true);
        Time.timeScale = 0.3f;
           
    }
    }
}
