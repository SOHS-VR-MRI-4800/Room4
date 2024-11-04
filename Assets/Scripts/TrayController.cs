using UnityEngine;

public class TrayController : MonoBehaviour
{
    public Transform tray;        // Assign the tray object in the Inspector
    public float liftSpeed = 0.05f; // Speed for tray lift
    public float slideSpeed = 0.1f; // Speed for tray slide
    public Vector3 maxLiftPosition; // Set max lift position in the Inspector
    public Vector3 maxSlidePosition; // Set max slide position in the Inspector

    private bool lifting = false;
    private bool slidingIn = false;
    private bool slidingOut = false;

    void Update()
    {
        if (lifting)
        {
            tray.localPosition = Vector3.MoveTowards(tray.localPosition, maxLiftPosition, liftSpeed * Time.deltaTime);
        }

        if (slidingIn)
        {
            tray.localPosition = Vector3.MoveTowards(tray.localPosition, maxSlidePosition, slideSpeed * Time.deltaTime);
        }

        if (slidingOut)
        {
            tray.localPosition = Vector3.MoveTowards(tray.localPosition, maxLiftPosition, slideSpeed * Time.deltaTime);
        }
    }

    public void StartLifting() => lifting = true;
    public void StopLifting() => lifting = false;

    public void StartSlidingIn() => slidingIn = true;
    public void StopSlidingIn() => slidingIn = false;

    public void StartSlidingOut() => slidingOut = true;
    public void StopSlidingOut() => slidingOut = false;
}
