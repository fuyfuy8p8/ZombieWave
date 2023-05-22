using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Camera _aimCamera;
    [SerializeField] private GameObject _mashPlayer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _mainCamera.enabled = false;
            _mashPlayer.SetActive(false);
            _aimCamera.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            _mainCamera.enabled = true;
            _mashPlayer.SetActive(true);
            _aimCamera.gameObject.SetActive(false);
        }
    }
}
