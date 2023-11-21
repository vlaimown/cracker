using UnityEngine;
using UnityEngine.UI;

public class Instrument : MonoBehaviour
{
    [SerializeField] private Text instrumentText;
    [SerializeField] private string instrumentName;

    [SerializeField] private int ChangePinValue1;
    [SerializeField] private int ChangePinValue2;
    [SerializeField] private int ChangePinValue3;

    [SerializeField] private Pin Pin1;
    [SerializeField] private Pin Pin2;
    [SerializeField] private Pin Pin3;

    void Start()
    {
        instrumentText.text = $"{ChangePinValue1}|{ChangePinValue2}|{ChangePinValue3}\n {instrumentName}";
    }

    public void ChangePinValue () 
    {
        int changed1 = Pin1.GetPinValue() + ChangePinValue1;
        Pin1.SetPinValue(changed1);

        int changed2 = Pin2.GetPinValue() + ChangePinValue2;
        Pin2.SetPinValue(changed2);

        int changed3 = Pin3.GetPinValue() + ChangePinValue3;
        Pin3.SetPinValue(changed3);
    }
}
