using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleport;
    public GameObject rightTeleport;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    [SerializeField] InputActionProperty _leftCancel;
    [SerializeField] InputActionProperty _rightCancel;

    private void Update()
    {
        leftTeleport.SetActive(_leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleport.SetActive(_rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
