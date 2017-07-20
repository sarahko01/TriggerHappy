using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    public int Health, MaxHealth;
    public Text HealthText;
	// Use this for initialization
	void Start () {
        Health = 10;
        MaxHealth = Health;
        HealthText.text = "HP: " + Health + " / " + MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.text = "HP: " + Health + " / " + MaxHealth;
        if (Health <= 0)
        {
            SceneManager.LoadScene("RayCastShootComplete");
        }
    }
}
