using UnityEngine;

public class GerakanMaju : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 = 10;
        int number2 = 7;
        int number3 = number1;
        Debug.Log("Sebelum Ditukar");
        Debug.Log("number 1 = " +number1);
        Debug.Log("number 2 = " + number2);
        number1 = number2;
        number2 = number3;
        Debug.Log("Setelah Ditukar");
        Debug.Log("number 1 = " +number1);
        Debug.Log("number 2 = " + number2);
        

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello World");
    }
}
