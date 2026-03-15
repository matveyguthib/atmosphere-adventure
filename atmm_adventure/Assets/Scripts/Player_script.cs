using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float _speed = 5f;
    private float _jump = 4f;
    private Vector2 _startedPos;
    public Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _startedPos = transform.position;
        _spriteRenderer = GetComponent<SpriteRenderer>(); // Получаем компонент для отзеркаливания спрайта
    }

    void Update()
    {
        // Движение вправо
        if (Input.GetKey(KeyCode.D))
        {
            _rb.linearVelocity = new Vector2(_speed, _rb.linearVelocity.y);
            _spriteRenderer.flipX = false; // Смотрим вправо (без отражения)
        }
        // Движение влево
        else if (Input.GetKey(KeyCode.A))
        {
            _rb.linearVelocity = new Vector2(-_speed, _rb.linearVelocity.y);
            _spriteRenderer.flipX = true; // Смотрим влево (отражаем спрайт)
        }

        // Прыжок (сохраняем текущую горизонтальную скорость)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _jump);
        }
    }
}