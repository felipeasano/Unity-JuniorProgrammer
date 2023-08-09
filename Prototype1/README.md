# Prototype 1

Neste projeto foram desenvolvidas atividades de aprendizado para o uso da ferramenta Unity

Linguagem utilizada: **C#**

Com pouco codigo foi possivel realizar atividades como:

1. Aplicar movimento a objetos
1. Controle de intencidade do movimento
1. Conceder controle de direcao pela entrada de usuario
1. Fazer com que a camera acompanhe um objeto em especifico

Alem disso foram aprendidos conceitos especificos como:

1. Tipo de dado **GameObject**
1. vetor de controle **Vector3[]**
1. Modo Gaming
1. **Posiocionamento** de objetos
1. **Rotacao** de Objetos
1. **Scripts**

## Código

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este Script tem a funcao de fazer com que a camera siga determinado objeto

public class FollowPlayer : MonoBehaviour
{
    // o tipo GameObject representa objetos dentro do cenario podendo apontar ou receber a referencia de um deles
    public GameObject player;
    private Vector3 offset = new Vector3 (0, 5, -8);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
```

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este Script tem a funcao de controlar a movimentacao de um determinado objeto
// Desta forma, direcao e rotacao sao controlado pela entrada de usuario

public class PlayerController : MonoBehaviour
{
    // O caracter "f" entra no final do numero para indicar seu tipo, no caso, um "float"
    // Private Variables 
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the car based on horizontal input
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
```

## Demonstracao

![Demonstracao](/Prototype1/demonstration.gif)


## Objetos e Cenarios

Os objetos e cenarios foram disponibilizados pelo proprio curso da Unity de maneira gratuita.