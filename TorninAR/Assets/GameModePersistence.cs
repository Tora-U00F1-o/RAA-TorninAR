using UnityEngine;

public class GameModePersistence : MonoBehaviour
{
    // Variable estática para la instancia
    public static GameModePersistence Instance;
    private GameObject obj;

    public bool practiceMode = true;

    void Awake()
    {
        // Comprobar si ya existe una instancia
        if (Instance == null)
        {
            // Si no, esta instancia se convierte en la única
            Instance = this;
            obj = gameObject;
            DontDestroyOnLoad(gameObject); // Evita destruir al cargar nueva escena
        }
        else
        {
            // Si ya existe otra instancia, destruir esta para evitar duplicados
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }


    // Aquí puedes añadir más funciones según tus necesidades
}