using UnityEngine;

public static class ShootingTypes
{
    [Header("RIFLE")]
    public static float rifleBulletSpeed = 19f;
    public static float rifleBulletLifeTime = 1.3f;
    public static float rifleFireRate = 0.08f;
    public static int rifleDamage = 10;

    [Header("Pistol")]
    public static float pistolBulletSpeed = 19f;
    public static float pistolBulletLifeTime = 1.0f;
    public static float pistolFireRate = 0.2f;
    public static int pistolDamage = 20;

    [Header("RPG")]
    public static float rpgBulletSpeed = 6f;
    public static float rpgBulletLifeTime = 2.0f;
    public static float rpgFireRate = 1.7f;
    public static int rpgDamage = 100;
}
