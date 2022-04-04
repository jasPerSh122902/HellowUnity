using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnTurrent : MonoBehaviour
{
    [SerializeField]
    GameObject _turrentRef;

    private void OnMouseDown()
    {
        GameObject turrent = Instantiate(_turrentRef.gameObject, null);
    }

}