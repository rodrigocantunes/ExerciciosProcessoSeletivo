using System.Collections.Generic;
using System.Linq;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio1
    {

        /// <summary>
        /// Retorne os functionarios ativos (em que a variavel excluido é falsa)
        /// </summary>
        /// <returns></returns>
        public List<(string funcionario, int codigo, bool excluido)> GetFuncionariosAtivos()
        {
            var funcionariosAtivos = new List<(string funcionario, int codigo, bool excluido)>();

            var funcionariosBancoDedados = new List<(string funcionario, int codigo, bool excluido)>
            {
                ("Carolina", 1, false),
                ("Dante", 8, false),
                ("Paulo", 2, false),
                ("Rodrigo", 4, false),
                ("Jose", 7, true),
                ("Clara", 6, true),
                ("Marcia", 10, true),
                ("Augusto", 9, false),
            };

            //COLOQUE A SOLUÇÃO A PARTIR DA LINHA ABAIXO.
            funcionariosAtivos = funcionariosBancoDedados;

            return funcionariosAtivos;
        }


    }
}
