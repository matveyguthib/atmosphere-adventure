using UnityEngine;

public class moving_bg : MonoBehaviour
{
    public float speed;
    public GameObject teleportRoad;
    public float backLength;
    public int backsCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > teleportRoad.transform.position.y)
        {
            transform.position = new Vector3(
                transform.position.x, 
                transform.position.y - backLength * backsCount
            );
        }
    }
}