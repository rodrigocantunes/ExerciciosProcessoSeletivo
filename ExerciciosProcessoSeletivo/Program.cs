using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProcessoSeletivo
{
    class Program
    {
        /// <summary>
        /// Mostre o resultado de cada Exercicio na tela
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var ex1 = new Exercicio1();
            //dentro do metodo GetFuncionariosAtivos liste apenas os funcionarios ativos
            var funcionarios = ex1.GetFuncionariosAtivos();
            //DICA: USE UM LOOP DE REPETIÇÃO PARA MOSTRAR O NOME DE CADA FUNCIONARIO
            //-----------------------------------------


            //ordene on codigos dentro do metodo GetCodigosOrdenados()
            var ex2 = new Exercicio2();
            var codigos = funcionarios.Select(x => x.codigo).ToList();
            var codigosOrdenados = ex2.GetCodigosOrdenados(codigos);
            //DICA: USE UM LOOP DE REPETIÇÃO PARA MOSTRAR OS CODIGOS ORDENADOS NA TELA
            //--------------------

            //Complete a clausula do funcionario dentro no metodo GerarClausula()
            var ex3 = new Exercicio3();
            //Depois de resolver o exercicio 3
            //Descomente a linha a baixo, passe o nome do funcionario como parametro e mostre a clausula na tela
            foreach(var funcionario in funcionarios)
            {
                //var clausula = ex3.GerarClausula();
            }

        }
    }
}
