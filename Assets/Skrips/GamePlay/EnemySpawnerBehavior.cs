using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private EnemyMovmentBehavior _enemy;
    [SerializeField]
    private Transform _enemyTarget;
    [SerializeField]
    private float _spawnTimer = 5;
    private float _timer = 0.0f;

    private void Update()
    {
        if (_spawnTimer <= _timer)
        {
            EnemyMovmentBehavior spawnEnemy = Instantiate(_enemy, transform.position, transform.rotation);
            spawnEnemy.Target = _enemyTarget;
            _timer = 0.0F;
        }
        else
            _timer += Time.deltaTime;
    }

}
