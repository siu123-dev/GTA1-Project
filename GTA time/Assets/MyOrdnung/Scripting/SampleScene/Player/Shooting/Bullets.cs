using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float lifeTime = 2f;   // Wie lange die Kugel existiert

    void Start()
    {
        if(PlayerManager.Instance.currentWeapon == CurrentWeapon.Rifle)
        {
            Destroy(gameObject, ShootingTypes.rifleBulletLifeTime); // Lebensdauer für Rifle-Kugeln
        }
        else if(PlayerManager.Instance.currentWeapon == CurrentWeapon.Pistol)
        {
            Destroy(gameObject, ShootingTypes.pistolBulletLifeTime); // Lebensdauer für Pistol-Kugeln
        }
        else if(PlayerManager.Instance.currentWeapon == CurrentWeapon.RPG)
        {
            Destroy(gameObject, ShootingTypes.rpgBulletLifeTime); // Lebensdauer für RPG-Kugeln
        }
    }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.tag != "Player")
            {
                Destroy(gameObject);
            }
        }
}