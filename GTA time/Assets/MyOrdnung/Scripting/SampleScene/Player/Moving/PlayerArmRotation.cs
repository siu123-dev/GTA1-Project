using UnityEngine;

public class PlayerArmRotation : MonoBehaviour
{
    public float speed = 5f;
    public Transform playerArm;
    void FixedUpdate()
    {
        RotateArmTowardsMouse();
    }

    public void RotateArmTowardsMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePosition - transform.position);
            mousePosition.z = 0f;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
        
    }
}
