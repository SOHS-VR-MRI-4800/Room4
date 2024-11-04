using UnityEngine;

public class Button4Interaction : MonoBehaviour
{
    public GameObject laserCrosshair;

    void OnMouseDown()
    {
        laserCrosshair.SetActive(!laserCrosshair.activeSelf);
    }
}
