using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField]
    List<Player> ListPlayer = new List<Player>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = ListPlayer.Find(element => element.Name == "Budi");
        Debug.Log(player.Level);
        // bool isExsist = ListPlayer.Exists(element => element == "fadhli");
        // Debug.Log(isExsist);
        // ListPlayer.insert(1, "anton");
        // ListPlayer.RemoveAt(0);

    }
}
