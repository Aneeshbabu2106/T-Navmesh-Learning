using UnityEngine;
using UnityEngine.AI; 

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
