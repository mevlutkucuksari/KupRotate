using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int CounterValue = 0;
    
    public static Counter counter;
    public TMP_Text TmpText;
    
    private void Awake()
    {
        counter = this;
    }

    public void IncreaseCounter()
    {
        CounterValue++;
        TmpText.text = CounterValue.ToString();
    }
}
