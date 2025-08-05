using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;

    bool isFiring = false;

    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        LaserFiring();
        MoveCrosshair();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void LaserFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emmissionModule = laser.GetComponent<ParticleSystem>().emission;
            emmissionModule.enabled = isFiring;
        }
    }

    void MoveCrosshair()
    {
        crosshair.position = Input.mousePosition;
    }
}
