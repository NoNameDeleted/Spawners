using System.Collections;
using UnityEngine;

public class Distributor : MonoBehaviour
{
    [SerializeField] private float _delay = 2.0f;
    [SerializeField] private Spawner[] _spawners;

    private void Start()
    {
        StartCoroutine(ChooseSpawner(_delay));
    }

    private IEnumerator ChooseSpawner(float delay)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        while (true)
        {
            Spawner spawner = _spawners[Random.Range(0, _spawners.Length)];
            spawner.SpawnEnemy();

            yield return wait;
        }
    }
}
