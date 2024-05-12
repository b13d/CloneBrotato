using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    
    void Start()
    {
        StartCoroutine(Countdown());
    }


    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2f);

        Instantiate(_enemy, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
