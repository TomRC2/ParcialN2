using UnityEngine;

// Clase Chest que representa un cofre que puede abrirse. Hereda de TempleObject.
// Aplica Polimorfismo al definir su propia versión de Interact().

public class Chest : TempleObject
{
    private bool isOpen = false; // Encapsulamiento básico (no expone el estado fuera de la clase)

    // Lógica específica del cofre: se abre si no fue abierto antes.
    public override void Interact()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log($"{objectName} fue abierto y contiene un objeto mágico.");
        }
        else
        {
            Debug.Log($"{objectName} ya estaba abierto.");
        }
    }
}
