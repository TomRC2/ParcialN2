using UnityEngine;

// Clase Chest que representa un cofre que puede abrirse. Hereda de TempleObject.
// Aplica Polimorfismo al definir su propia versi�n de Interact().

public class Chest : TempleObject
{
    private bool isOpen = false; // Encapsulamiento b�sico (no expone el estado fuera de la clase)

    // L�gica espec�fica del cofre: se abre si no fue abierto antes.
    public override void Interact()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log($"{objectName} fue abierto y contiene un objeto m�gico.");
        }
        else
        {
            Debug.Log($"{objectName} ya estaba abierto.");
        }
    }
}
