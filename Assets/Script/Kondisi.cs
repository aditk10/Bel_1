using System;
using UnityEngine;

public class Kondisi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int nyawa = 0;
    void Start()
    {
        Debug.Log(TambahHidup(10, 11, 12));
            
    }

    public void MinumObat()
    {
        Debug.Log("pemain minum obat");
        TambahNyawa(10);
    }

    public void TambahNyawa(int Tambah)
    {
        nyawa = nyawa + Tambah;
    }
    public int TambahHidup(int angka1, int angka2, int angka3)
    {
        int result = angka1 + angka2 + angka3;
        return result;
    }
}
