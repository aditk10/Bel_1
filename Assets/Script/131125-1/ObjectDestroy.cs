using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D objectTerdeteksi = Physics2D.OverlapPoint(PosisiKlik);
            if (objectTerdeteksi != null)
            {
                Destroy(objectTerdeteksi.gameObject);
            }
        }
    }
}
