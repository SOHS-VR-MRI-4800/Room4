using UnityEngine;

public class Button2Interaction : MonoBehaviour
{
    public Animator tableAnimator;

    void OnMouseDown()
    {
        tableAnimator.SetBool("MoveBackward", true);
    }

    void OnMouseUp()
    {
        tableAnimator.SetBool("MoveBackward", false);
    }
}
