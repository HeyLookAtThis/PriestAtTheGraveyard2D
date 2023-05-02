using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementType
{
    vertical, horizontal
}

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _pathTime = 6.0f;
    [SerializeField] private float _seconds = 0.5f;
    [SerializeField] private MovementType _movementType;

    private Rigidbody2D _rigidbody;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void StartMoving()
    {
        StartCoroutine(Walker());
    }

    private IEnumerator Walker()
    {
        var waitForSecond = new WaitForSeconds(_seconds);

        float direction = 1.0f;
        float oppositeDirection = -1;

        int coroutineCounter = 0;

        while (coroutineCounter <= _pathTime)
        {
            if (coroutineCounter == _pathTime)
            {
                direction *= oppositeDirection;

                if (_movementType == MovementType.horizontal)
                    ChangeRotation(direction);

                coroutineCounter = 0;
            }

            PassSegment(direction);
            coroutineCounter++;

            yield return waitForSecond;
        }
    }
    
    private void PassSegment(float direction)
    {
        if (_movementType == MovementType.horizontal)
            _rigidbody.velocity = new Vector2(direction * _speed, _rigidbody.velocity.y);
        else
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, direction * _speed);
    }

    private void ChangeRotation(float direction)
    {
        if (direction > 0)
            _sprite.flipX = false;
        else
            _sprite.flipX = true;
    }
}
