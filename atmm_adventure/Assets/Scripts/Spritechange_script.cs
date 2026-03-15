using UnityEngine;

public class SimpleSpriteChanger : MonoBehaviour
{
    public Sprite spriteIdle;      // Спрайт в покое
    public Sprite spriteWalking;   // Спрайт при ходьбе
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Проверяем горизонтальную скорость, чтобы понять, движется ли игрок
        if (Mathf.Abs(rb.linearVelocity.x) > 0.1f)
        {
            spriteRenderer.sprite = spriteWalking;
        }
        else
        {
            spriteRenderer.sprite = spriteIdle;
        }
    }
}