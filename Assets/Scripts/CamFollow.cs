using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    float mouseSpeed = 1;
    float orbitDamping = 30;
    Vector3 localRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
        localRot.x += Input.GetAxis("Mouse X") * mouseSpeed; //izquierda=negativo //derecha=positivo
        localRot.y -= Input.GetAxis("Mouse Y") * mouseSpeed;
        localRot.y = Mathf.Clamp(localRot.y, 0f, 80f);

        Quaternion qt = Quaternion.Euler(localRot.y, localRot.x, 0f); //EL ULTIMO PARAM ES LOS GRADOS QUE GIRA LA CÁMARA (num positivo = camara se inclina hacia la derecha)
        //te lo crea según la rotación del ratón (? - z no la usamos bc ratón no tiene forma de girar en z, la dejamos en 0 (para la z podríamos usar el mousewheel para hacer zoom)
        transform.rotation = Quaternion.Lerp(transform.rotation, qt, Time.deltaTime * orbitDamping); //desde punto en el que estaba cámara, qt es lo que quieres girar desde ahí y el tercer parámetro idk que es 
        
    }
}
