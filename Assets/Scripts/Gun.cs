using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
