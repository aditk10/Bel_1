using UnityEngine;

public class TabrakBola : MonoBehaviour
{
    public intraksi12B Intraksi12B;
    // SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Intraksi12B.nyawa = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Karakter"))
        {
            // Debug.Log("Bola Nabrak Karakter");
            Debug.Log("kotak menabrak bola");
            Intraksi12B.nyawa--;
            KurangNyawa();
        }

    }
    public void KurangNyawa()
    {
        Intraksi12B.TeksNyawa.text = "Nyawa : " + Intraksi12B.nyawa.ToString();
    }
}
