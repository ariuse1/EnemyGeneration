using UnityEngine;

public class Jellyfish : MonoBehaviour
{
    [SerializeField] private Vector2 _direction;
    [SerializeField] private float _speed;

    public void SetDirection(Vector2 direction, float speed)
    {
        _direction = direction;
        _speed = speed;
    }

    private void FixedUpdate()
    {
        transform.Translate(_direction.normalized * _speed * Time.deltaTime);       
    }   
}
