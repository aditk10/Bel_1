using UnityEngine;

public class SquareMove13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //boolean untuk kontrol arah gerak

    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight == true)
            {
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            } else
            {
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }
    }
}
