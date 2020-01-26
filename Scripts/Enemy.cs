using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public GameObject Player;


    public float impulseForce;

    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player") { 
        Player.GetComponent<Rigidbody>().AddForce(
            transform.forward * impulseForce, ForceMode.Impulse); }
    }
    public void SetupVariables()
    {
        navAgent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void MoveTowardsPlayer() {
        navAgent.destination = Player.transform.position;

    }
    public void MoveAwayPlayer()
    {
        navAgent.destination = Player.transform.position * -1;

    }
}
