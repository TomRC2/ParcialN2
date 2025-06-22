using UnityEngine;

// Clase que representa una puerta. Hereda de TempleObject.

public class Door : TempleObject
{
    // Polimorfismo: implementación específica de Interact().
    public override void Interact()
    {
        if (PlayerInventory.Instance.HasKey)
        {
            Debug.Log("Puerta desbloqueada y abierta.");
            Destroy(gameObject); // o animación de abrir
        }
        else
        {
            Debug.Log("Está cerrada. Necesitás una llave.");
        }
    }
}
