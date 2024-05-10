using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    public static Camera mainCamera;


    private void Awake()
    {
        instance = this;
        mainCamera = Camera.main;
    }


    public static void FitCameraToBoard()
    {
        float basePos_X = (Board.boardWidth - 1) * 0.5f;
        float basePos_Y = Board.boardHeight * 0.25f;

        Vector3 cameraPos = mainCamera.gameObject.transform.position;
        cameraPos.x = basePos_X;
        cameraPos.y = basePos_Y;

        mainCamera.gameObject.transform.position = cameraPos;
        mainCamera.orthographicSize = Board.boardWidth;
    }
}
    