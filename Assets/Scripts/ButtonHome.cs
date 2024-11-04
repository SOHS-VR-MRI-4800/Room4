using UnityEngine;

public class Button3Interaction : MonoBehaviour
{
    public Animator tableAnimator;

    void OnMouseDown()
    {
        tableAnimator.SetTrigger("ResetPosition");
    }
}
