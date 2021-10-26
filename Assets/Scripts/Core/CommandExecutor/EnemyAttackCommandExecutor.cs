using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackCommandExecutor : MonoBehaviour
{
    [SerializeField] private float _radius = 5f;
    [SerializeField] private CommandExecutorAttack _executorAttack;

    private List<float> _distances = new List<float>();
    private float _distance;
    private Collider[] _hitColliders;
    private Collider _collider;
    

    private void Update()
    {
        _hitColliders = Physics.OverlapSphere(transform.position, _radius);
        var dist = 5f;

        for (var i = 1; i < _hitColliders.Length; i++)
        {
            if (_hitColliders[i].CompareTag("Unit"))
            {
                if(dist > (_hitColliders[i].transform.position - transform.position).magnitude)
                {
                    dist = (_hitColliders[i].transform.position - transform.position).magnitude;
                    _collider = _hitColliders[i];
                }
            }
        }

        //Debug.Log($"{_collider.gameObject} - {dist}");

        RunAttack(_collider);
        
    }

    private async void RunAttack(Collider _collider)
    {
        await _executorAttack.ExecuteSpecificCommand((IAttackCommand)_collider);
    }
}
