using UnityEngine;

public class Array : MonoBehaviour
{
    // public string[] ArrayNama = { "Asep", "Budi", "Tono" };
    [SerializeField]

    Player[] ArrayPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // menampilkan data array ke-1
        // Debug.Log(ArrayNama[1]);
        // Debug.Log("Array ke 0 = " + ArrayNama[0]);
        // mengganti nilai Array
        // ArrayNama[0] = "Andi";
        // Debug.Log("Array ke 0 = " +ArrayNama[0]);
        //menampilkan panjang Array
        // Debug.Log(ArrayNama.Length);

        // for (int index = 0; index < ArrayPlayer.Length; index++)
        // {
        //     Debug.Log(ArrayPlayer[index].Name);
        // }

        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
            Debug.Log(player.Level);
            Debug.Log(player.Health);
        }

        // Debug.Log(ArrayPlayer.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
