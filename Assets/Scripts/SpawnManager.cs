using UnityEngine;

// Script que instancia objetos din�micamente al inicio.
// Cumple con el requisito de instanciaci�n por c�digo (din�mica).

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Lista de prefabs de enemigos
    public Transform[] spawnPoints; // Posiciones en el mapa donde se pueden generar

    void Start()
    {
        foreach (var point in spawnPoints)
        {
            int index = Random.Range(0, objectsToSpawn.Length);
            Instantiate(objectsToSpawn[index], point.position, point.rotation);
        }
    }
}
