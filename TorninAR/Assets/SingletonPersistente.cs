using UnityEngine;

public class SingletonPersistente : MonoBehaviour
{
    // Variable estática para la instancia
    public static SingletonPersistente Instance;
    private GameObject obj;

    void Awake()
    {
        // Comprobar si ya existe una instancia
        if (Instance == null)
        {
            Debug.Log(" es null -> se crea");
            // Si no, esta instancia se convierte en la única
            Instance = this;
            obj = gameObject;
            DontDestroyOnLoad(gameObject); // Evita destruir al cargar nueva escena
        }
        else
        {
            enable(false);
            Debug.Log("ya existe");
            // Si ya existe otra instancia, destruir esta para evitar duplicados
            if (Instance != this)
            {
                Debug.Log("se destrulle la otra");
                Destroy(gameObject);
                enable(true);
            }
        }
    }

    private void enable(bool active) {
        if(obj != null) {
            
            obj.SetActive(active);
        }
    }

    // Aquí puedes añadir más funciones según tus necesidades
}