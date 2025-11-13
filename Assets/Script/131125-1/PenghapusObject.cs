using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour
{
    void Start()
    {
        // StartCoroutine(HapusObject());
        Destroy(gameObject, 5);
    }
    
//     IEnumerator HapusObject()
//     {

//         yield return new WaitForSeconds(2);
//         Destroy(gameObject);
//     }
}
