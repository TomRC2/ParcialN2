using UnityEngine;

// Script que instancia objetos dinámicamente al inicio.
// Cumple con el requisito de instanciación por código (dinámica).

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
