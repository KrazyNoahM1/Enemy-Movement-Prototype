using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{
    int rotated = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                Vector3 currentRotation = transform.eulerAngles;
                transform.eulerAngles = new Vector3(currentRotation.x, currentRotation.y, currentRotation.z + 120f);
                rotated++;
                if (rotated > 3)
                {
                    rotated = 0;
                }
            }
                
        }
    }
}
