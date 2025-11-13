using TMPro;
using UnityEngine;

public class intraksi12B : MonoBehaviour
{
    //fungsi digunakan untuk memanggil kode dari file squaremove2 agar fungsi-fungsi bisa dipanggil
    public SquareMove2 squareMove2;

    //deklarasi variable skor
    public int skor;

    //deklarasi variable untuk mengubah skor
    public TMP_Text TeksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //pendeteksian arah gerak object kotak
    public void GerakAtas()
    {
        squareMove2.arahGerakB = ArahGerakB.atas;
    }
    public void GerakBawah()
    {
        squareMove2.arahGerakB = ArahGerakB.bawah;
    }
    public void GerakKanan()
    {
        squareMove2.arahGerakB = ArahGerakB.kanan;
    }
    public void GerakKiri()
    {
        squareMove2.arahGerakB = ArahGerakB.kiri;
    }
}
