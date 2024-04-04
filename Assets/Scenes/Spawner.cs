using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        StartCoroutine(SpawnObject(_delay, _enemy));
    }

    private IEnumerator SpawnObject(float delay, GameObject _object)
    {
        var wait = new WaitForSeconds(delay);

        while (true)
        {
            Transform spawner = transform.GetChild(Random.Range(0, transform.childCount));
            Instantiate(_object, spawner.position, spawner.rotation);

            yield return wait;
        }
    }
}
