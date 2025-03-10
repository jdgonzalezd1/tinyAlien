using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController player;
    public CinemachineVirtualCamera virtualCamera;
    private CinemachineFramingTransposer transposer;
    private float scaleChange;

    private void Start()
    {
        transposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
    }

    private void LateUpdate()
    {
        scaleChange = player.transform.localScale.y;
        transposer.m_CameraDistance = scaleChange + 0.5f;
    }
}