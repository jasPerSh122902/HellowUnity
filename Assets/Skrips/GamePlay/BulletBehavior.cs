using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //private Rigidbody _rigidBody;
    private string _ownerTag;
    [SerializeField]
    private int _damage;

    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }
    //// Update is called once per frame
    //void Start()
    //{
    //    _rigidBody = GetComponent<Rigidbody>();
    //}
    //// Update is called once per frame
    //void Update()
    //{

    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(OwnerTag))
            return;

        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        if (!otherHealth)
            return;

        otherHealth.TakeDamage(_damage);
    }
}
