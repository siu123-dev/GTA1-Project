using UnityEngine;

public class AudioManager : MonoBehaviour // Dieses Script steuert die Musik und Soundeffekte im Spiel. Es wird als Singleton implementiert, damit es von überall im Spiel leicht zugänglich ist. Es enthält Methoden zum Abspielen von Musik und Soundeffekten, einschließlich eines speziellen "Pop"-Sounds für UI-Interaktionen.
{
    public static AudioManager Instance;

    [Header("Music")]
    public AudioSource musicSource;

    [Header("SFX")]
    public AudioSource sfxSource;
    public AudioClip popClip;

    void Awake()
    {
        // Singleton Pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // bleibt zwischen Szenen erhalten
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 🎵 Musik starten
    public void PlayMusic(AudioClip clip)
    {
        if (musicSource.clip == clip) return;

        musicSource.clip = clip;
        musicSource.loop = true;
        musicSource.Play();
    }

    // Allgemeine SFX Methode
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    // Spezieller UI Sound (dein "Pop")
    public void PlayPop()
    {
        sfxSource.PlayOneShot(popClip);
    }
}