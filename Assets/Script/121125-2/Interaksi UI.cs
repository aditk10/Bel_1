using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public Squaremove squaremove;
    public GameObject SquareUbahWarna;
    public TMP_Text KataBerubah;
    public TMP_Text KataUbah;
    public List<string> daftarNama;
    public int idNama = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KataUbah.text = daftarNama[idNama];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UbahKataKiri()
    {
        string kata = "Kiri";
        KataBerubah.text = kata;
    }
    public void UbahKataKanan()
    {
        string kata = "kanan";
        KataBerubah.text = kata;
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        KataUbah.text = daftarNama[idNama];
    }
    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        KataUbah.text = daftarNama[idNama];
    }

    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }

    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }

    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);
    }
    public void UbahWarnaKuning()
    {
        UbahWarna(Color.yellow);
    }
    public void UbahWarnaAcak()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        UbahWarna(col);
    }

    public void Mulai()
    {
        squaremove.isMove = true;
    }
    
    public void Berhenti()
    {
        squaremove.isMove = false;
    }
    public void Kanan()
    {
        squaremove.isMoveRight = true;
    }
    public void Kiri()
    {
        squaremove.isMoveRight = false;
    }

}
