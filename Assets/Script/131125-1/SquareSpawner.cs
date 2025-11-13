using System.Collections;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    public bool SedangSpawn = true;

    private void Start()
    {
        StartCoroutine(MunculkanObject());
    }
    
    IEnumerator MunculkanObject()
    {
        while(SedangSpawn == true)
        {
            //Spawn oject
            Instantiate(SpawnObject, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);
            //delay 5s
            yield return new WaitForSeconds(5);
        }
    }
}
