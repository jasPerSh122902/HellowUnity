using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmiterBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletRef;
    [SerializeField]
    private GameObject _owner;
    [SerializeField]
    private float _bulletForce;

    public void Fire() 
    {
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);
        BulletBehavior bulletBehavior = bullet.GetComponent<BulletBehavior>();
        bulletBehavior.OwnerTag = _owner.tag;

        bulletBehavior.Rigidbody.AddForce(transform.forward * _bulletForce, ForceMode.Impulse);

    }
}
