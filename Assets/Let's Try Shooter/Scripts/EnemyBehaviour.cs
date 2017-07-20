using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour {
    private NavMeshAgent nav;
    private GameObject Target;
	// Use this for initialization
	void Start () {
        nav = this.GetComponent<NavMeshAgent>();
        Target = GameObject.FindWithTag("Player");
        nav.SetDestination(Target.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        nav.SetDestination(Target.transform.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            other.GetComponent<PlayerStats>().Health -= 1;
        }
    }
}
