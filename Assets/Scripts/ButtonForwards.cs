using UnityEngine;

public class Button1Interaction : MonoBehaviour
{
    public Animator tableAnimator;

    void OnMouseDown()
    {
        tableAnimator.SetBool("MoveForward", true);
    }

    void OnMouseUp()
    {
        tableAnimator.SetBool("MoveForward", false);
    }
}
