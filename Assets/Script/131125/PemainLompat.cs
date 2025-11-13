using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    public bool diLantai;
    //variabel perhitungan untuk daya lompat
    public float forceMultiplier = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        } else
        {
            Debug.Log("lagi di lantai");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = true;
            Debug.Log("Lagi di lantai");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = false;
            Debug.Log("Lagi Terbang");
        }
    }
}
