using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour
{
    [SerializeField] private string transitionName;

    private void Start()
    {
        if(transitionName == SceneManagement.Instance.SceneTransitionName) {
            PlayerController.Instance.transform.position = transform.position;
            CameraController.Instance.SetPlatyerCameraFollow();
            UIFade.Instance.FadeToWhite();
        }
    }
}
