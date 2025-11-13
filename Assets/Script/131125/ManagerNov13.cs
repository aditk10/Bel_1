using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public TMP_Text teksSkor;
    public int skor;
    public SquareMove13 squareMove13;

    //variabel untuk referensi
    public GameObject bolaJatuh;

    public PemainLompat pemainLompat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTeksSkor();
    }

    // Update is called once per frame
    void Update()
    {
        //mendeteksi input berupa klik mouse
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Klik Kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            // ToggleKiriKanan();
            squareMove13.isMoveRight = false;
            MunculDariAtas(); //memanggil fungsi MunculDariAtas
            pemainLompat.lompat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik Kanan");
            KurangSkor();
            UpdateTeksSkor();
            squareMove13.isMoveRight = true;
        }
        // if (Input.GetMouseButtonDown(2))
        // {
        //     Debug.Log("Klik Tengah");
        // }
    }

    void TambahSkor()
    {
        skor++;
        Debug.Log("Skor Bertambah = ");
    }
    void KurangSkor()
    {
        skor--;
        Debug.Log("Skor Berkurang = ");
    }
    void UpdateTeksSkor()
    {
        teksSkor.text = skor.ToString();
        Debug.Log("Skor update = ");
    }

    void ToggleKiriKanan()
    {
        if (squareMove13.isMoveRight)
        {
            squareMove13.isMoveRight = false;
        }
        else
        {
            squareMove13.isMoveRight = true;
        }
    }
    
    void MunculDariAtas()
    {
        //ambil posisi dimana kursor mouse berada
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //ambil posisi titik paling atas layar
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar untuk vector3 bernama tempatJauh
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikAtas.y, 0);

        //memunculkan object dengan nama bola jatuh di posisi tempatjatuh dan dengan rotasi Quarternion.identity
        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);
    }
}
