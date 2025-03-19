using System;
using System.Collections;
using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class testeraycast : MonoBehaviour
{
    Ray raio;
    Vector3 local;
    RaycastHit hitData;
    UnityEngine.Color cor;
    public Camera ccamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Começou uhul");
        StartCoroutine(GerarTarget());


    }

    // Update is called once per frame
    void Update()
    {

        if (UnityEngine.Input.GetKey(KeyCode.Mouse0)) // Quando clicar no botão direito do mouse...
        {

            raio = Camera.main.ScreenPointToRay(Input.mousePosition); // Localiza a posição do mouse na tela
            cor = UnityEngine.Color.red; // Define a cor, vermelho
            Atirar(raio, cor, 1); // Chama o método, e define as propriedades
        }
        if (UnityEngine.Input.GetKey(KeyCode.E)) // Quando clicar na tecla E...
        {
            raio = new Ray(transform.position, transform.forward); // Define a posição do objeto, e o centro do objeto, de onde o raio  vai sair
            cor = UnityEngine.Color.green; // Define a cor, verde
            Atirar(raio, cor, 2); // Chama o método, e define as propriedades
}

        if (UnityEngine.Input.GetKey(KeyCode.Q)) // Quando clicar na tecla Q...
        {
            local = new Vector3(ccamera.pixelWidth / 2, ccamera.pixelHeight / 2, 0); //ta definindo o centro da câmera, pegando a altura e dividindo por 2, depois fazendo o mesmo com a largura.
            raio = ccamera.ScreenPointToRay(local); //definindo a origem do raio
            cor = UnityEngine.Color.yellow; //cor do raio
            Atirar(raio, cor, 3);// chamando o método e definindo propriedades
        }
    }
    private void Atirar(Ray raio, UnityEngine.Color cor, int tipo)
    {
        Debug.Log("Inicio " + raio.origin);
        Debug.Log("Caminho " + raio.direction);

        if (Physics.Raycast(raio, out hitData))
        {
            Vector3 LocalDeImpacto = hitData.point;
            Debug.Log("Local de impacto: " + LocalDeImpacto);

            float hitDistance= hitData.distance;


            Debug.Log("Distancia: " + hitDistance);
            string tag = hitData.collider.tag;
            Debug.Log("Tag:" + tag);
            GameObject hitObject = hitData.transform.gameObject;
            Debug.DrawRay(raio.origin, LocalDeImpacto * hitDistance, cor);
            StartCoroutine(SphereIndicator(LocalDeImpacto, tipo));

            if (tag == "target")
                Destroy(hitObject);
        }
        else
        {
            Debug.DrawRay(raio.origin, raio.direction * 1000, UnityEngine.Color.magenta);
            Debug.Log("Target missed");
        }
    }
    private IEnumerator SphereIndicator(Vector3 pos, int tipo)
    {
        GameObject gameObj = null;
        switch (tipo)
        {
            case 1:
                gameObj = CriaObject(pos, "cherry");
                break;
            case 2:
                gameObj = CriaObject(pos, "white");
                break;
            case 3:
                gameObj = CriaObject(pos, "blue");
                break;

        }


        yield return new WaitForSeconds(1);
        Destroy(gameObj);
    }

    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = UnityEngine.Color.red;

        Gizmos.DrawRay(raio);
    }

    GameObject CriaObject(Vector3 pos, string material)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        sphere.transform.localScale = new Vector3(3, 3, 3);
        string src = string.Concat("material/", material);
        Material bombMaterial = Resources.Load(src, typeof(Material)) as Material;

        sphere.GetComponent<Renderer>().material = bombMaterial;
        return sphere;
    }

    GameObject InstanciaPrefab(Vector3 pos)
    {

        GameObject prefab = Resources.Load("prefab/bomb", typeof(GameObject)) as GameObject;

        return Instantiate(prefab, pos, Quaternion.identity);
    }

    private IEnumerator GerarTarget()
    {
        while (true)
        {
            float x = Random.Range(-150.0f, 80.0f);
            float y = Random.Range(-34.0f, 45.0f);
            float z = Random.Range(-50.0f, 5.0f);
            Vector3 position = new Vector3(x, y, z);
            Instantiate(Resources.Load("prefab/target", typeof(GameObject)) as GameObject, position, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }

}
    
