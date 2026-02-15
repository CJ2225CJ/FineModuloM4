using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timeRemaning = 300; // seconds
    [SerializeField] private float timeReset = 300;
    [SerializeField] private GameObject Player; 
    private int damage = 100;

    void Update()
    {
        if (timeRemaning > 0)
        {
            timeRemaning -= Time.deltaTime;
        }
        if (timeRemaning <= 0 && Player.TryGetComponent<LifeController>(out LifeController life))
        {
            TimeReset(timeReset);
            life.TakeDamage(damage);
        }
        timerText.text = timeRemaning.ToString();
        int minuts = Mathf.FloorToInt(timeRemaning / 60);
        int seconds = Mathf.FloorToInt(timeRemaning % 60); 
        timerText.text = string.Format("{0:00}:{1:00}", minuts, seconds);
    }
    private void TimeReset(float timeReseter)
    {
        timeRemaning = timeReset;
    }
}
