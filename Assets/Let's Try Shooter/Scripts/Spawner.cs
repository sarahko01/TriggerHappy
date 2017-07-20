using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour {

    [HideInInspector] public bool CurrentlyActive;
    public GameObject Enemy;
    public int spawnTime;
    // Use this for initialization
    void Start()
    {
        CurrentlyActive = true;
        StartCoroutine(TheSpawner());
    }

    private IEnumerator TheSpawner()
    {
        while (CurrentlyActive == true)
        {
            var go = Instantiate(Enemy);
            go.transform.position = this.gameObject.transform.position;
            yield return new WaitForSeconds(spawnTime);
        }
    }

}
