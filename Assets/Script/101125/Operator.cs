using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool x = ((1287 * 14 + 589) > (63 + 55 * 5)) && !(21 < 10);
    void Start()
    {
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
