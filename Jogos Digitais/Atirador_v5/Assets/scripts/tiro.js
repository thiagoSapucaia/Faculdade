import UnityEngine.Transform;

//Velocidade do tiro
var speed = 3.0; 

// Variavel global para indexar o prefabs (Falar sobre o ctrl+space)
var bolaPrefab:Transform;

function Update () {
	
	// Disparar esferas
	if(Input.GetButtonDown("Fire1")){
			
		//Criar uma instancia de um prefab
		var bola = Instantiate(bolaPrefab,transform.position,Quaternion.identity);
		
		//Adicionar força na bola
		bola.GetComponent.<Rigidbody>().AddForce(transform.forward * 2000);
	
	}

}