using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBars : MonoBehaviour {

 public int maxHealth = 7;
    public int maxPortalGun = 2000;
    public int currentHealthStatus;
    public int currentPortalGunStatus;
    public HealthBar healthBar;
    public PortalGunBar portalGunBar;
    
    // The Time's Up text object.
    public GameObject timesUpText;

    // public AudioSource dead;
    public AudioSource lowEnergy;
    public AudioSource lowLife;
    // public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start() {
        currentHealthStatus = maxHealth;
        currentPortalGunStatus = maxPortalGun;

        healthBar.SetMaxHealth(maxHealth);
        portalGunBar.SetMaxGunPower(maxPortalGun);
    }

    // Update is called once per frame
    void Update() {
        if(currentPortalGunStatus > 0 ) {
            currentPortalGunStatus -= 1;
            portalGunBar.SetGunPower(currentPortalGunStatus);
        }else{
            timesUpText.SetActive (true);
            Time.timeScale = 0;
        }

        if(currentPortalGunStatus == 500){
            lowEnergy.Play();
        }

        // if(Input.GetKeyDown(KeyCode.Space)) {
        //     TakeDamage(1);
        // }
        
    }

    void AddPowerPortalGun(int power) {
        currentPortalGunStatus += power;
        portalGunBar.SetGunPower(currentPortalGunStatus);
    }

    void TakeDamage(int damage){
        currentHealthStatus -= damage;
        if(currentHealthStatus == 1){
            lowLife.Play();
        }
        healthBar.SetHealth(currentHealthStatus);
    }

    void OnTriggerEnter2D(Collider2D other) {
          Debug.Log("enemy triger!");
        if (other.gameObject.CompareTag("powerGun")){
           AddPowerPortalGun(400);
        }
     }
    
}
