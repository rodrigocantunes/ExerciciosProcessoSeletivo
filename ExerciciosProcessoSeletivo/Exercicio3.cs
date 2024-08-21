using System;

namespace ExerciciosProcessoSeletivo
{
    public class Exercicio3
    {
        /// <summary>
        /// FAÇA COM QUE O NOME DO FUNCIONARIO APAREÇA NO LUGAR DE {nome.ToUpper()}
        /// FAÇA COM QUE A DATA DE HOJE APAREÇA NO LUGAR DE {data}, COM O FORMATO DD/MM/YYYY (SEM HORA E MINUTO)
        /// </summary>
        /// <param name="nome"></param>
        public string GerarClausula(string nome)
        {
            var data = DateTime.Now;
            var clausula = "O FUNCIONÁRIO {nome.ToUpper()}, É CONTRATADO PELA EMPRESA YPSUM\nPARA PRESTAR SERVIÇOS DE DESENVOLVEDOR. DATA: {data}";

            return clausula;
        }


    }
}
