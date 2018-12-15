using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemigostontos : MonoBehaviour {

    [SerializeField]  int tiempoEntreRotacion = 2;
    [SerializeField] int inicioRotacion = 1;
    [SerializeField] Text txtPuntuacion;
    public Camera camaraPpal;
    public Camera camaraSec;
    int puntos;



    private void Awake()
    {
        camaraSec.enabled = false;
        puntos = 0;
    }


    void Start() {

        
        InvokeRepeating("RotarAleatoriamente", inicioRotacion, tiempoEntreRotacion);

    }

     void Update() {
        if (puntos >= 5)
        {
            //SceneManager.LoadScene(3);
            camaraPpal.enabled = false;
            camaraSec.enabled = true;

        }

        Avanzar();
       
       

    }
    public void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);

        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }

    public void Avanzar() {

        int speed = 1;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        

    }

    public void Destruir()
    {
        Destroy(this);
    }

  
  

    private void OnCollisionEnter(Collision other)
    {
        GameObject objetivoImpacto = other.gameObject;

        if (objetivoImpacto.CompareTag("Proyectil"))
        {
            Debug.Log("Impacto Proyectil");






            GetComponent<Animator>().SetBool("ostiado", true);
            puntos = puntos + 1;
            txtPuntuacion.text = "Puntuacion: " + puntos;
            print("cogiendo puntos");
            








        }

      
    }
    void Destruccion()
    {
       // GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Rigidbody>().AddRelativeForce(0, 1000, 1000);
    }
    void DestruirPersonaje()
        
    {
        Invoke("Destruccion", 0.1f);
    }
    
}

   

