using UnityEngine;

public class LaserControl : MonoBehaviour
{
    public Projector laserProjector;
    public LayerMask projectionLayers;

    void Start()
    {
        if (laserProjector != null)
        {
            laserProjector.enabled = false;
            laserProjector.ignoreLayers = ~projectionLayers;
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Replace with your input method
        {
            ActivateLaser();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            DeactivateLaser();
        }
    }

    void ActivateLaser()
    {
        if (laserProjector != null)
        {
            laserProjector.enabled = true;
        }
    }

    void DeactivateLaser()
    {
        if (laserProjector != null)
        {
            laserProjector.enabled = false;
        }
    }
}
