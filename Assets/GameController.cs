using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Pin Pin1;
    [SerializeField] private Pin Pin2;
    [SerializeField] private Pin Pin3;

    private int currentValuePin1;
    private int currentValuePin2;
    private int currentValuePin3;

    private int unlockValue1;
    private int unlockValue2;
    private int unlockValue3;

    [SerializeField] private GameObject victoryWindow;
    [SerializeField] private GameObject defeatWindow;
    [SerializeField] private GameObject gameWindow;

    [SerializeField] private Timer timer;

    void Update()
    {
        currentValuePin1 = Pin1.GetPinValue();
        currentValuePin2 = Pin2.GetPinValue();
        currentValuePin3 = Pin3.GetPinValue();

        if (currentValuePin1 == unlockValue1 && currentValuePin2 == unlockValue2 && currentValuePin3 == unlockValue3 && gameWindow.activeSelf)
        {
            victoryWindow.SetActive(true);
            gameWindow.SetActive(false);
        }

        if (timer.IsTimeIsOver())
            defeatWindow.SetActive(true);
    }

    public void StartGame()
    {
        timer.ResetTimer();
        SetPins();
    }

    public void Restart()
    {
        StartGame();
        defeatWindow.SetActive(false);
        victoryWindow.SetActive(false);
    }

    private void SetPins()
    {
        System.Random rnd = new System.Random();

        currentValuePin1 = Pin1.GetPinValue();
        currentValuePin2 = Pin2.GetPinValue();
        currentValuePin3 = Pin3.GetPinValue();

        unlockValue1 = rnd.Next(1, 10);
        unlockValue2 = rnd.Next(1, 10);
        unlockValue3 = rnd.Next(1, 10);

        while (currentValuePin1 == unlockValue1 && currentValuePin2 == unlockValue2 && currentValuePin3 == unlockValue3)
        {
            unlockValue1 = rnd.Next(1, 10);
            unlockValue2 = rnd.Next(1, 10);
            unlockValue3 = rnd.Next(1, 10);
        }

        Debug.Log($"{unlockValue1} {unlockValue2} {unlockValue3}");
    }
}
