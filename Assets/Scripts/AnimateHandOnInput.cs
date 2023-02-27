using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimAction;
    public InputActionProperty gripAnimAction;

    public Animator handAnim;

    private void Update()
    {
        float triggerValue = pinchAnimAction.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", triggerValue);

        float gripValue = pinchAnimAction.action.ReadValue<float>();
        handAnim.SetFloat("Trigger", gripValue);
    }
}
