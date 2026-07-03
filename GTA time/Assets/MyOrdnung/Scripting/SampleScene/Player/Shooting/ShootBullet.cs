using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab der Kugel
    public Transform firePoint;      // Punkt, von dem die Kugel abgefeuert wird
    public float bulletSpeed = 10f;  // Geschwindigkeit der Kugel
    public float fireRate = 0.5f;    // Feuerrate (Sekunden zwischen den Schüssen)

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Linke Maustaste gedrückt
        {
            if(PlayerManager.Instance.currentWeapon == CurrentWeapon.Rifle && PlayerShootingState.isAllowedToShoot)
            {
                bulletSpeed = ShootingTypes.rifleBulletSpeed; // Geschwindigkeit für Rifle-Kugeln
                fireRate = ShootingTypes.rifleFireRate; // Feuerrate für Rifle
                StartCoroutine(Shoot());
                Debug.Log("Rifle shot fired");
            }
            else if(PlayerManager.Instance.currentWeapon == CurrentWeapon.Pistol && PlayerShootingState.isAllowedToShoot)
            {
                bulletSpeed = ShootingTypes.pistolBulletSpeed; // Geschwindigkeit für Pistol-Kugeln
                fireRate = ShootingTypes.pistolFireRate; // Feuerrate für Pistol
                StartCoroutine(Shoot());
                Debug.Log("Pistol shot fired");
            }
            else if(PlayerManager.Instance.currentWeapon == CurrentWeapon.RPG && PlayerShootingState.isAllowedToShoot)
            {
                bulletSpeed = ShootingTypes.rpgBulletSpeed; // Geschwindigkeit für RPG-Kugeln
                fireRate = ShootingTypes.rpgFireRate; // Feuerrate für RPG
                StartCoroutine(Shoot());
                Debug.Log("RPG shot fired");
            }
        }
    }

    public IEnumerator Shoot()
    {
        PlayerShootingState.isAllowedToShoot = false; // Verhindert, dass der Spieler während des Schießens erneut schießt

        // Erstelle eine neue Kugel am Feuerpunkt
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // Füge der Kugel eine Geschwindigkeit hinzu
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
        rb.linearVelocity = -firePoint.up * bulletSpeed;
        
        yield return new WaitForSeconds(fireRate);
        PlayerShootingState.isAllowedToShoot = true; // Erlaube dem Spieler wieder zu schießen
    }
}