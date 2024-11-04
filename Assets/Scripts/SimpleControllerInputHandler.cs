using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleControllerInputHandler : MonoBehaviour
{
    public InputActionProperty selectAction;
    public InputActionProperty menuAction;

    void OnEnable()
    {
        selectAction.action.performed += OnSelectPerformed;
        menuAction.action.performed += OnMenuPerformed;
    }

    void OnDisable()
    {
        selectAction.action.performed -= OnSelectPerformed;
        menuAction.action.performed -= OnMenuPerformed;
    }

    private void OnSelectPerformed(InputAction.CallbackContext context)
    {
        // Handle select action
        Debug.Log("Select action performed");
    }

    private void OnMenuPerformed(InputAction.CallbackContext context)
    {
        // Handle menu action
        Debug.Log("Menu action performed");
    }
}
