using UnityEngine;
using System.Collections;

public class Arma {

	string nome;
	int dano;
	int velocidade;
	int critico;
	int peso;
	int tipo;
	int durabilidade;
	int efeito;
	int alcance;


	public Arma(string nome, int dano, int velocidade, int critico,
	            int peso, int tipo, int durabilidade, int efeito, int alcance){

		this.nome = nome;
		this.dano = dano;
		this.velocidade = velocidade;
		this.critico = critico;
		this.peso = peso;
		this.tipo = tipo;
		this.durabilidade = durabilidade;
		this.efeito = efeito;
		this.alcance = alcance;
				
	}
	


	public void ataque1(){
		Arma novaArma = new Arma ("Luiz", 30, 10, 2, 80, 0, 100, 1, 30);
	}
	public void ataque2(){

	}
	public void habilidade(){

	}
}
