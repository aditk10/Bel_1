using UnityEngine;

public class SquareMove2 : MonoBehaviour
{
    //deklarasi fungsi ArahGerakB diawali kearah kanan
    public ArahGerakB arahGerakB = ArahGerakB.kanan;

    //deklarasi referensi GameObject dengan tipe data class interaksi
    //digunakan untuk komunikasi dengan GameObject yang memiliki class interaksi 12B
    //setelah deklarasi
    public intraksi12B Intraksi12B; 
    
    //deklarasi variabel kecepatan dengan tipe data float yang digunakan untuk mengatur kecepatan
    public float kecepatan = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    //mengatur kecetapan dari object
    void Update()
    {
        switch (arahGerakB)
        {
            case ArahGerakB.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerakB.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerakB.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerakB.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }

    //mendeteksi apakah object kotak menabrak dinding
    //apabila object kota menabark dinding, maka object akan memantul kearah sebaliknya
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak Menabrak Dinding");
            if (arahGerakB == ArahGerakB.atas)
            {
                arahGerakB = ArahGerakB.bawah;
            }
            else if (arahGerakB == ArahGerakB.bawah)
            {
                arahGerakB = ArahGerakB.atas;
            }
            else if (arahGerakB == ArahGerakB.kiri)
            {
                arahGerakB = ArahGerakB.kanan;
            }
            else
            {
                arahGerakB = ArahGerakB.kiri;
            }
            Intraksi12B.skor++;
            TambahSkor();
        }
    }
    //penambahan skor setelah menabrak dinding
    public void TambahSkor()
    {
        Intraksi12B.TeksSkor.text = "skor : " + Intraksi12B.skor.ToString();
    }
}

//Deklarasi Enumerator dengan nama arah
//isi enumeratornya adalah arah atas, bawah, kanan dan kiri
public enum ArahGerakB
{
    atas,
    bawah,
    kanan,
    kiri

}
