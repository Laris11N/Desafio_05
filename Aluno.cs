using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_05
{
	
	public class Aluno
	{
		/*public Aluno(string nome, int idade, int nota)
	{
		Nome = nome;
		Idade = idade;
		Nota = nota;
	}*/
		public string Nome { get; set; }
		public int Idade { get; set; }
		public int Nota { get; set; }

		/* Removido após add na variavel local 
		 
		public string Nome2 { get; set; }
		public int Idade2 { get; set; }
		public int Nota2 { get; set; }

		public string Nome3 { get; set; }
		public int Idade3 { get; set; }
		public int Nota3 { get; set; }*/


		 public static implicit operator string(Aluno aluno)
		
			=> $"{aluno.Nome}, {aluno.Idade}, {aluno.Nota}";

		
	}
	
}

