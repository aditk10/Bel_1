using UnityEngine;

public class KotakWarna : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Color warna;
        //_spriteRenderer.color = Color.cyan;

        ColorUtility.TryParseHtmlString("#A3F23B", out warna);
        _spriteRenderer.color = warna;


    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
