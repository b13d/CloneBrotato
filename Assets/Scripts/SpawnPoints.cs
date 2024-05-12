using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField]
    private GameObject _point;

    private float _second = 1f;
 

    void Update()
    {
        _second -= Time.deltaTime;

        if (_second < 0f)
        {
            _second = 1f;

            Instantiate(_point, new Vector2(Random.Range(-7.5f, 7.5f), Random.Range(-3.5f, 3.5f)),Quaternion.identity, transform);
        }
    }
}
