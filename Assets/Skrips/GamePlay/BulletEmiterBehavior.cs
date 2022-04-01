using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmiterBehavior : MonoBehaviour
{

    private GameObject _bullet;
    private float _bulletForce;

    public void Fire() 
    {
        GameObject bullet = Instantiate(_bullet.gameObject, null);
        Rigidbody bulletRigidBody = bullet.GetComponent<Rigidbody>();
        BulletBehavior bulletBehavior = bullet.GetComponent<BulletBehavior>();

    }
}
