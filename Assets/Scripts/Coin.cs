using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int coinValue = 50;
    bool coinEnabled = true;
    public static event Action<int> OnCoinTaken;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!coinEnabled) return;
        coinEnabled = false;
        OnCoinTaken?.Invoke(coinValue);
        Destroy(gameObject);
        AudioManager.instance.PlaySFX("coin");

    }
}
