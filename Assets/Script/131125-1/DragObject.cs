using Unity.Mathematics;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    // void OnMouseEnter()
    // {
    //     Debug.Log("Enter");
    // }
    // void OnMouseDown()
    // {
    //     Debug.Log("Down");
    // }
    void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //membatasi posisi kotak hanya horisontal saja
        //kalau ingi vertikal worldMousePosition.x diganti y
        Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);
        Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        // squarePosition.x = Mathf.Clamp(squarePosition.x, -8, 8);
        squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x,  maximum.x);
        
        transform.position = squarePosition;
    }
    // void OnMouseExit()
    // {
    //     Debug.Log("Exit");
    // }
    
}
