using UnityEngine;

// Clase que representa una trampa. Hereda de TempleObject.
// Se aplica Polimorfismo al definir una l�gica �nica de interacci�n.

public class Trap : TempleObject
{
    public override void Interact()
    {
        Debug.Log($"{objectName} activa una trampa. �Cuidado!");
    }
}
