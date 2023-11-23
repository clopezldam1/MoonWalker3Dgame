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

        Quaternion qt = Quaternion.Euler(localRot.y, localRot.x, 0f); //EL ULTIMO PARAM ES LOS GRADOS QUE GIRA LA C�MARA (num positivo = camara se inclina hacia la derecha)
        //te lo crea seg�n la rotaci�n del rat�n (? - z no la usamos bc rat�n no tiene forma de girar en z, la dejamos en 0 (para la z podr�amos usar el mousewheel para hacer zoom)
        transform.rotation = Quaternion.Lerp(transform.rotation, qt, Time.deltaTime * orbitDamping); //desde punto en el que estaba c�mara, qt es lo que quieres girar desde ah� y el tercer par�metro idk que es 
        
    }
}
