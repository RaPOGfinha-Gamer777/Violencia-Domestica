using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D playerOneBody;
    public Rigidbody2D playerTwoBody;

    public float moveSpeed;

    void Update()
    {
        MovePlayerOne();
        MovePlayerTwo();
    }

    void MovePlayerOne()
    {
        float horizontalOne = Input.GetAxis("Horizontal_Player1");
        float verticalOne = Input.GetAxis("Vertical_Player1");

        Transform objTransform = playerOneBody.GetComponent<Transform>();

        playerOneBody.velocity = new Vector2(horizontalOne, verticalOne) * moveSpeed;

        objTransform.position = new Vector3(objTransform.position.x, objTransform.position.y, objTransform.position.y);

    }
    void MovePlayerTwo()
    {
        float horizontalTwo = Input.GetAxis("Horizontal_Player2");
        float verticalTwo = Input.GetAxis("Vertical_Player2");

        Transform objTransform = playerTwoBody.GetComponent<Transform>();

        playerTwoBody.velocity = new Vector2(horizontalTwo, verticalTwo) * moveSpeed;

        objTransform.position = new Vector3(objTransform.position.x, objTransform.position.y, objTransform.position.y);
    }
}
