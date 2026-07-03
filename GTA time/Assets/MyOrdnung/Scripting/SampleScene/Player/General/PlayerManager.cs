using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PlayerManager>();
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    _instance = singletonObject.AddComponent<PlayerManager>();
                    singletonObject.name = typeof(PlayerManager).ToString() + " (Singleton)";
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        // 3. Check for duplicates to ensure only one instance exists
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        _instance = this;
    }

    public PlayerStates currentState = PlayerStates.Walking;
    public CurrentWeapon currentWeapon = CurrentWeapon.Rifle;
}
