using UnityEngine;
using UnityEngine.UI;


public class Pin : MonoBehaviour
{
    [SerializeField] private int pin;
    [SerializeField] private Text pinText;
    private System.Random rnd = new System.Random();

    void Start()
    {
        pin = rnd.Next(1, 10);
        pinText.text = pin.ToString();
    }

    public int GetPinValue ()
    { 
        return pin;
    }

    public void SetPinValue (int value) 
    {
        if (value > 1 && value < 10) 
        {
            pin = value;
            pinText.text = pin.ToString();
        }
    }
}
