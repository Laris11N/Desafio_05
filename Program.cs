using Desafio_05;
using System;
using System.Collections.Generic;

namespace Desafio_05
{
	class Program
	{
		static void Main(string[] args)
			
		{				
			List<Aluno> listaAluno = new List<Aluno>();

			Aluno aluno = new Aluno();
			aluno.Nome = "Joaquina";
			aluno.Idade = 40;
			aluno.Nota = 8;

			Aluno aluno2 = new Aluno();
			aluno2.Nome = "Jeremias";
			aluno2.Idade = 27;
			aluno2.Nota = 5;

			Aluno aluno3 = new Aluno();
			aluno3.Nome = "Joana";
			aluno3.Idade = 30;
			aluno3.Nota = 10;

			listaAluno.Add(aluno);

			foreach (Aluno aluno1 in listaAluno)
			{
				Console.WriteLine("A soma da nota dos alunos é: " + (aluno.Nota + aluno2.Nota + aluno3.Nota));

			}

			foreach (Aluno item in listaAluno)
			{
			  Console.WriteLine(aluno);
				Console.WriteLine(aluno2);
				Console.WriteLine(aluno3);
			}

			Console.ReadLine();
		}

	}
}

/* Desenvolver um sistema que soma a nota 
  de 3 alunos e emita Relatorio excel CSV. 
  1 - Representar o Aluno com classe
Aluno (Nome, Idade, Nota)
List<Aluno> alunos = new List<Aluno>();
3 - Salvar resultado em arquivos CSV para cada aluno com
todos os dados e notas*/
