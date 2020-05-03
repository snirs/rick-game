using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinPicker : MonoBehaviour
{
    public TextMeshProUGUI textCoins;
    public AudioSource audioSource;
    
    private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("coin")){
            audioSource.Play();
            coin += 10;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }

    }
}
