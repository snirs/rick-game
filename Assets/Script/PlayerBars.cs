using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBars : MonoBehaviour {

    public Animator anim;
    
    public int maxHealth = 7;
    public int maxPortalGun = 2000;
    public int currentHealthStatus;
    public int currentPortalGunStatus;
    public HealthBar healthBar;
    public PortalGunBar portalGunBar;

    public PauseMenu pauseMenu;
    
    // The Time's Up text object.
    public GameObject timesUpText;

    public GameObject gameOverMenuUI;
    // public AudioSource dead;
    public AudioSource lowEnergy;
    public AudioSource lowLife;
    public AudioSource takeDamage;
    // public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
        currentHealthStatus = maxHealth;
        currentPortalGunStatus = maxPortalGun;

        healthBar.SetMaxHealth(maxHealth);
        portalGunBar.SetMaxGunPower(maxPortalGun);
    }

    // Update is called once per frame
    void Update() {
        if(currentPortalGunStatus > 0 ) {
            if (PauseMenu.GameIsPaused == false){
                currentPortalGunStatus -= 1;
                portalGunBar.SetGunPower(currentPortalGunStatus);
            }
            }else{
//            pauseMenu.gameOverMenuUI.SetActive(true);
            timesUpText.SetActive (true);
            Time.timeScale = 0f;
        
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

        else if (other.gameObject.CompareTag("enemy")){
        TakeDamage(1);
        anim.Play("rickTakeDamage");
        takeDamage.Play();

        Debug.Log("Damage is");
        }
     }

    int getPortalGunStatus(){
         return currentPortalGunStatus;
     }

    void RestartGame(){
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    void LoadMenu(){
        Application.Quit();
    }

    
}
