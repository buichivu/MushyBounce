using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header(" Control Setting ")]

    [SerializeField]private float moveSpeed;
    [SerializeField]private float maxX;

    private float clickedScreenX;
    private float clickedPlayerX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManagerControl();

    }

    private void ManagerControl()
    {

        if (Input.GetMouseButtonDown(0))
        {
            clickedScreenX = Input.mousePosition.x;
            clickedPlayerX = transform.position.x;
        }

        else if (Input.GetMouseButton(0))
        {
            float xDifference = Input.mousePosition.x - clickedScreenX;
            xDifference /= Screen.width;
            xDifference *= moveSpeed;

            float newXPosition = clickedPlayerX + xDifference;

            newXPosition = Mathf.Clamp(newXPosition, -maxX, maxX);

            transform.position = new Vector2(newXPosition, transform.position.y);
            Debug.Log("x difference = " + xDifference);
        }
    }
}
