using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Controller : MonoBehaviour
{
    private NavMeshAgent npc_controller;
    [SerializeField] private Transform _followTarget;
    [SerializeField] private NavMeshAgent _master;
    private Animator _animator;

    private void Start()
    {
        npc_controller = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_master.velocity.magnitude > Vector3.zero.magnitude)
        {
            npc_controller.destination = _followTarget.position;
        }

        if (npc_controller.velocity != Vector3.zero)
        {
            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }
}
