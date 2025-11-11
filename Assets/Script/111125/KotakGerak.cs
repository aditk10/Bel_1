using UnityEngine;

public class KotakGerak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 3.0F;
    public bool isMoveRight = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        } else
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Kotak Bertabrakan");
        if (isMoveRight)
        {
            isMoveRight = false;
        }
        else
        {
            isMoveRight = true;
        }
        if (collision.gameObject.CompareTag("Kotak Tabrak"))
        {
            Debug.Log("Kotak bertabrakan");
            SpriteRenderer _spriteRenderer;

            _spriteRenderer = GetComponent<SpriteRenderer>();

            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

            _spriteRenderer.color = warnaAcak;
        }
    }
}
