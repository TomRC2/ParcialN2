using UnityEngine;

// Clase abstracta base para todos los objetos del templo que pueden ser interactuados.
// Aplica Abstracción al definir un comportamiento general sin necesidad de conocer la implementación exacta.
// También se aplica Herencia, ya que otras clases la extenderán.

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    // Variable pública para identificar el objeto (podría usarse para mostrar el nombre en pantalla).
    public string objectName;

    // Método abstracto que cada clase hija debe implementar. Esto fuerza a que todas tengan su propia lógica de interacción.
    public abstract void Interact();

    // Método virtual que puede ser sobreescrito por las clases hijas si lo necesitan.
    protected virtual void Start()
    {
        Debug.Log($"{objectName} ha sido cargado.");
    }
}
