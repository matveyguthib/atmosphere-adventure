using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;        // Персонаж, за которым следит камера
    public Vector3 offset = new Vector3(0, 0, -10); // Смещение (обычно по Z = -10 для ортографической камеры)
    public float smoothSpeed = 5f;  // Скорость сглаживания

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Камера: цель не назначена!");
            return;
        }

        // Желаемая позиция камеры = позиция персонажа + смещение
        Vector3 desiredPosition = target.position + offset;

        // Плавно перемещаем камеру к желаемой позиции
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}