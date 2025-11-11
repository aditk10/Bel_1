
using UnityEngine;

public class KMG_CekInput : MonoBehaviour
{
    public GameObject _munculHilang;

    public GameObject _untukSpawn;

    public GameObject _targetHancur;

    public GameObject _ubahWarna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol Backspace Di Tekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O Dipencet, Object Muncul");
            _munculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P Di Tekan, Object Hilang");
            _munculHilang.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter Di Tekan");
            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-10, 10), 0), Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.Find("Sasaran");
            Debug.Log("Tombol M Di Pencet");
            Destroy(_targetHancur);
            Destroy(hancurkan);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer _localSpriteRenderer = _ubahWarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = warnaAcak;
        }


        
    }
}
