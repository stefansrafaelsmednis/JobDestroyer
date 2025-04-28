using UnityEngine.AI;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public NavMeshAgent agent:

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttackted;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playernAttackRange;

    private void Awake()
    {
        player = GameObject.Find(player).transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Patroling()
    {

    }
    private void patroling()

}
