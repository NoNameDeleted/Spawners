using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private ElementType _type;
    [SerializeField] private Target _target;
    [SerializeField] private Enemy _enemy;

    public void SpawnEnemy()
    {
        Enemy createdEnemy = Instantiate(_enemy, transform.position, transform.rotation);
        createdEnemy.SetDirection(_target.transform.position);
        createdEnemy.SetColorType(_type);
        createdEnemy.gameObject.SetActive(true);
    }
}
