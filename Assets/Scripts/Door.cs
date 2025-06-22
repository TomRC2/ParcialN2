using UnityEngine;

// Clase que representa una puerta. Hereda de TempleObject.

public class Door : TempleObject
{
    // Polimorfismo: implementaci�n espec�fica de Interact().
    public override void Interact()
    {
        if (PlayerInventory.Instance.HasKey)
        {
            Debug.Log("Puerta desbloqueada y abierta.");
            Destroy(gameObject); // o animaci�n de abrir
        }
        else
        {
            Debug.Log("Est� cerrada. Necesit�s una llave.");
        }
    }
}
