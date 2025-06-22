using UnityEngine;

public class Key : TempleObject
{
    public override void Interact()
    {
        Debug.Log("Recogiste una llave.");
        PlayerInventory.Instance.HasKey = true; // Guarda la llave en el inventario del jugador
        Destroy(gameObject); // Desaparece la llave
    }
}
