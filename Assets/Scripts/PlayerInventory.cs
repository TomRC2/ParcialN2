using UnityEngine;

// Clase con Singleton para guardar datos del jugador (Encapsulamiento)
public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    // Encapsulado: solo se modifica internamente
    public bool HasKey { get; set; } = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
}

