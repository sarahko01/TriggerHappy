using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour {

    public AudioSource wallAudioSource;
    public AudioClip carlAudioClip;

    public int Health, MaxHealth;
    public Text HealthText;
    public GameObject Roof;
    public List<GameObject> Test = new List<GameObject>();
    public GameObject UnitPrefab;
	// Use this for initialization
	void Start () {
        Health = 10;
        MaxHealth = Health;
        HealthText.text = "HP: " + Health + " / " + MaxHealth;
        Roof.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        HealthText.text = "HP: " + Health + " / " + MaxHealth;
        if (Health <= 0)
        {
            SceneManager.LoadScene("RayCastShootComplete");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            if (!wallAudioSource.isPlaying)
            {
                wallAudioSource.clip = carlAudioClip;
                wallAudioSource.Play();
                Roof.SetActive(false);
                foreach (var box in Test)
                {
                    var go = Instantiate(UnitPrefab, new Vector3(box.transform.position.x, 0, box.transform.position.z), Quaternion.identity);                    
                    Destroy(box);
                }
            }
        }
    }
}
