using UnityEngine;
using UnityEngine.Events;

public class CoinScript : MonoBehaviour
{
    public int coins = 0;
    public TMPro.TextMeshProUGUI textBox;
    public UnityEvent OnGainCoin;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textBox.text = $"Coins: {coins.ToString()}";
    }

    public void GainCoin()
    {
        coins += 1;
        OnGainCoin?.Invoke();
    }
}
