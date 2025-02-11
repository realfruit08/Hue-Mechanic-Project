using UnityEngine;

public class ColorWheelScript : MonoBehaviour
{

    public GameObject colorWheel;

    public GameObject PinkBoxes;
    public GameObject YellowBoxes;
    public GameObject BlueBoxes;
    public GameObject BlueBackdrop;
    public GameObject PinkBackdrop;
    public GameObject YellowBackdrop;
    public GameObject GreyBackdrop;
    public GameObject Backdrops;

    public void Blue()
    {
        PinkBoxes.SetActive(true);
        YellowBoxes.SetActive(true);
        BlueBoxes.SetActive(false);
        BlueBackdrop.SetActive(true);
        PinkBackdrop.SetActive(false);
        YellowBackdrop.SetActive(false);
        GreyBackdrop.SetActive(false);

        Time.timeScale = 1f;
    } 

    public void Yellow()
    {
        PinkBoxes.SetActive(true);
        YellowBoxes.SetActive(false);
        BlueBoxes.SetActive(true);
        BlueBackdrop.SetActive(false);
        PinkBackdrop.SetActive(false);
        YellowBackdrop.SetActive(true);
        GreyBackdrop.SetActive(false);

        Time.timeScale = 1f;
    }

    public void Pink()
    {
        PinkBoxes.SetActive(false);
        YellowBoxes.SetActive(true);
        BlueBoxes.SetActive(true);
        BlueBackdrop.SetActive(false);
        PinkBackdrop.SetActive(true);
        YellowBackdrop.SetActive(false);
        GreyBackdrop.SetActive(false);

        Time.timeScale = 1f;
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
            GreyBackdrop.SetActive(true);
            PinkBoxes.SetActive(true);
            YellowBoxes.SetActive(true);
            BlueBoxes.SetActive(true);
            Debug.Log("colorwheel?");
            colorWheel.SetActive(true);
            Time.timeScale = 0.3f;
        }

        BlueBoxes.SetActive(!BlueBackdrop.activeSelf);
    }
}
