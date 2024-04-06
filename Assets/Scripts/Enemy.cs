using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;
    private SpriteRenderer _spriteRenderer;

    private Dictionary<ElementType, Color> _colors = new Dictionary<ElementType, Color>()
    {
        {ElementType.Fire, Color.red},
        {ElementType.Grass, Color.green},
        {ElementType.Water, Color.blue},
        {ElementType.Ground, Color.black},
        {ElementType.Air, Color.white},
    };

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    public void SetColorType(ElementType type)
    {
        _spriteRenderer.color = _colors[type];
    }
    private void OnEnable()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _direction, _speed * Time.deltaTime);
    }
}
