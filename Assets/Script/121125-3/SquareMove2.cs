using UnityEngine;

public class SquareMove2 : MonoBehaviour
{
    public ArahGerakB arahGerakB = ArahGerakB.kanan;

    public intraksi12B Intraksi12B;
    public float kecepatan = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
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
    public void TambahSkor()
    {
        Intraksi12B.TeksSkor.text = "skor : " + Intraksi12B.skor.ToString();
    }
}

public enum ArahGerakB
{
    atas,
    bawah,
    kanan,
    kiri

}
