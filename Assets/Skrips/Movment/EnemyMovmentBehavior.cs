using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovmentBehavior : MovementBahavior
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private int _damage;

    public float Speed 
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Transform Target 
    {
        get { return _target; }
        set { _target = value; }
    }

    // Update is called once per frame
     public override void Update()
     {
        Vector3 distance = _target.position - transform.position;

        Velocity = distance.normalized * Speed;

        base.Update();
     }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //increament the enemy count if the target was a goal
            GoalBehavior goalHealth = other.GetComponent<GoalBehavior>();
            if (goalHealth)
                goalHealth.TakeDamage(_damage);
          //Destroyes this enemy
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// Destories the enemy if it was clicked with a mouse
    /// </summary>
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
