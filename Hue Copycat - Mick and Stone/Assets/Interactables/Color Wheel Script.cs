using UnityEngine;

public class ColorWheelScript : MonoBehaviour
{

    public GameObject colorWheel;

    public GameObject PinkBoxes;
    public GameObject YellowBoxes;
    public GameObject BlueBoxes;
    public void Blue()
    {
        PinkBoxes.SetActive(true);
        YellowBoxes.SetActive(true);
        BlueBoxes.SetActive(false);
    } 

    public void Yellow()
    {
        PinkBoxes.SetActive(true);
        YellowBoxes.SetActive(false);
        BlueBoxes.SetActive(true);
    }

    public void Pink()
    {
        PinkBoxes.SetActive(false);
        YellowBoxes.SetActive(true);
        BlueBoxes.SetActive(true);
    }

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
