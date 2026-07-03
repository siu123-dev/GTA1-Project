using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayerManager.Instance.currentWeapon = CurrentWeapon.Rifle;
            Debug.Log("Switched to Rifle");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayerManager.Instance.currentWeapon = CurrentWeapon.Pistol;
            Debug.Log("Switched to Pistol");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            PlayerManager.Instance.currentWeapon = CurrentWeapon.RPG;
            Debug.Log("Switched to RPG");
        }
    }
}
