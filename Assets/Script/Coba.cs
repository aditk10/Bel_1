using UnityEngine;

public class Coba : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // while
        // int nyawa = 10;
        // while (nyawa > 0)
        // {
        //     nyawa = nyawa - 1;
        //     Debug.Log(nyawa);
        // }
        // Debug.Log("Game Over");

        //for loop
        // for (int i = 0; i < 3; i++)
        // {
        //     Debug.Log("iterasi ke-" +i);
        // }

        // faktorial challenge 1
        // int n = 5;

        // long fact = 1;

        // for (int i = 1; i <= n; i++)
        // {
        //     fact *= i;
        // }
        // Debug.Log("Faktorial dari input = " + fact);

        // faktorial challenge 2
        int n = 4;

        for (int i = 1; i <= n; i++)
        {
            string baris = "";
            for (int j = 1; j <= i; j++)
            {
                baris += "*";
            }
            Debug.Log(baris); // Pindah ke baris berikutnya
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
