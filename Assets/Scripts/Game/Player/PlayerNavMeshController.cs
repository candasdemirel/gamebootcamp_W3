using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMeshController : MonoBehaviour
{
    private NavMeshAgent _player; //Player
    private RaycastHit _hitInfo = new RaycastHit();
    [SerializeField] private GameObject _targetIndicator;
    private bool isIndicatorOn;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray.origin, ray.direction, out _hitInfo))
            {
                _player.destination = _hitInfo.point;
                if (!isIndicatorOn) StartCoroutine(TargetIndicator(_hitInfo.point));
            }
        }
        if(_player.velocity != Vector3.zero)
        {
            _animator.SetBool("isWalking", true);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }

    }

    private IEnumerator TargetIndicator(Vector3 position)
    {
        isIndicatorOn = true;
        _targetIndicator.SetActive(true);
        _targetIndicator.transform.position = position;
        yield return new WaitForSeconds(0.5f);
        isIndicatorOn = false;
        _targetIndicator.SetActive(false);
    }
}
