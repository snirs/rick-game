using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GunPicker : MonoBehaviour
{
    // public TextMeshProUGUI textCoins;
     public AudioSource gunPick;
     public AudioSource thankYou;
    
    private PlayerPlatformerController playa;
    // private float coin = 0;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("powerGun")){
            gunPick.Play();
            thankYou.Play();
            // coin += 10;
            // textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }

    }
}
