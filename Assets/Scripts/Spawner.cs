using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawners;

    private void Start()
    {
        StartCoroutine(SpawnObject(_delay, _enemy));
    }

    private IEnumerator SpawnObject(float delay, Enemy enemy)
    {
        var wait = new WaitForSeconds(delay);

        while (true)
        {
            Transform spawnPoint = _spawners[Random.Range(0, _spawners.Length)];
            Enemy createdEnemy = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            createdEnemy.SetDirection(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0));

            yield return wait;
        }
    }
}
