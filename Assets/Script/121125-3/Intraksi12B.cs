using TMPro;
using UnityEngine;

public class intraksi12B : MonoBehaviour
{
    public SquareMove2 squareMove2;

    public int skor;

    public TMP_Text TeksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
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
