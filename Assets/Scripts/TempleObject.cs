using UnityEngine;

// Clase abstracta base para todos los objetos del templo que pueden ser interactuados.
// Aplica Abstracci�n al definir un comportamiento general sin necesidad de conocer la implementaci�n exacta.
// Tambi�n se aplica Herencia, ya que otras clases la extender�n.

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    // Variable p�blica para identificar el objeto (podr�a usarse para mostrar el nombre en pantalla).
    public string objectName;

    // M�todo abstracto que cada clase hija debe implementar. Esto fuerza a que todas tengan su propia l�gica de interacci�n.
    public abstract void Interact();

    // M�todo virtual que puede ser sobreescrito por las clases hijas si lo necesitan.
    protected virtual void Start()
    {
        Debug.Log($"{objectName} ha sido cargado.");
    }
}
