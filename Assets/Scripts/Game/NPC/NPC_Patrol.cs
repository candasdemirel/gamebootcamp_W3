using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using System;

public class NPC_Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] _wayPoints;
    private NavMeshAgent _npcController;
    private int _currentWP;

    private Transform _attackTarget;
    private Animator _animator;

    private bool isTarget = false;
    private bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        _npcController = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_npcController.velocity != Vector3.zero)
        {
            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }


        if (!isTarget) //Saldırı hedifimiz yok
        {
            if (Vector3.Distance( transform.position, _wayPoints[_currentWP].position) < Constants.WAY_POINT_CHECK_DISTANCE) //waypointe geldik
            {
                if(_currentWP >= _wayPoints.Length - 1)
                {
                    _currentWP = 0;
                }
                else
                {
                    _currentWP++;
                }
            }

            _npcController.destination = _wayPoints[_currentWP].position; // Sıradaki waypointe git
        }
        else if(isTarget) //Saldırı hedefimiz var
        {
            if (Vector3.Distance(transform.position, _attackTarget.position) > Constants.ATTACK_CHECK_DISTANCE)
            {

                _npcController.destination = _attackTarget.position; //Saldırı hedefimize git

            }
            else
            {
                if (!isAttacking) StartCoroutine(Attack());
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isTarget)
        {
            isTarget = true;
            _attackTarget = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isTarget)
        {
            isTarget = false;
            var wpList = _wayPoints.ToList();
            //wpList.OrderBy(x => (x.position - transform.position).sqrMagnitude);
            wpList.OrderBy(x => Vector3.Distance(x.position, transform.position));
            _currentWP = Array.IndexOf(_wayPoints, wpList.FirstOrDefault());

        }
    }

    private IEnumerator Attack()
    {

        isAttacking = true;
        _animator.SetBool("isKicking", isAttacking);
        yield return new WaitForSeconds(1f);
        isAttacking = false;
        _animator.SetBool("isKicking", isAttacking);


    }
}
