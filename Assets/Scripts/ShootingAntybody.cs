using UnityEngine;

public class ShootingAntybody : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;


    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

}
