using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;

    [SerializeField] private float maxTime = 60f;

    private float currentTime;
    private float convertedTime;
    private bool timeIsOver = false;

    private void Start()
    {
        currentTime = maxTime;
        timeIsOver = false;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        convertedTime = currentTime;
        convertedTime = Mathf.FloorToInt(convertedTime);

        if (currentTime > 0)
            timerText.text = convertedTime.ToString();
        else if (currentTime <= 0)
            currentTime = 0;

        if (currentTime == 0)
            timeIsOver = true;
    }

    public bool IsTimeIsOver()
    {
        return timeIsOver;
    }

    public void ResetTimer()
    {
        currentTime = maxTime;
        timeIsOver = false;
    }
}
