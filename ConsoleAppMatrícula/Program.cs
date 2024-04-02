using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMatrícula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagasDS = 5;
            int vagasMECA = 5;
            int vagasADM = 5;
            int vagasEDF = 5;

            int totalMatrículasDS = 0;
            int totalMatrículasMECA = 0;
            int totalMatrículasADM= 0;
            int totalMatrículasEDF= 0;

            Console.WriteLine("Sistema de Matrícula Etec Joaquim Ferreira do Amaral");

            Console.WriteLine("Qual o nome do aluno?: ");
            Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento do aluno?: ");
            Console.ReadLine();
            Console.WriteLine("Qual o CPF do aluno?: ");
            Console.ReadLine();

            while (resposta == sim) ;
            {

                Console.WriteLine("Em qual curso você deseja se matrícular? DS, MECA, ADM ou EDF");
                string c = Console.ReadLine();

                int curso = int.Parse(Console.ReadLine());

                if (curso == 0)
                {
                    Console.WriteLine("Matrícula encerrada");
                    break;
                }
                switch (curso)
                {
                    case 0:
                        if (vagasDS <= 5)
                        {
                            Console.WriteLine("Matrícula em DS realizada com sucesso");
                            Console.ReadLine();
                            
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para DS");
                        }
                        break;
                    case 1:
                        if (vagasMECA <= 5)
                        {
                            Console.WriteLine("Matrícula em MECA realizada com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para MECA");
                        }
                        break;
                    case 2:
                        if (vagasADM <= 5)
                        {
                            Console.WriteLine("Matrícula em ADM realizada com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para ADM");
                        }
                        break;
                    case 3:
                        if (vagasEDF <= 5)
                        {
                            Console.WriteLine("Matrícula em EDF realizada com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não há vagas disponíveis para EDF");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            Console.WriteLine("Total de matriculados em DS: "+ (totalMatrículasDS));
            Console.WriteLine("Total de matriculados em MECA: "+(totalMatrículasMECA));
            Console.WriteLine("Total de matriculados em ADM: "+ (totalMatrículasADM));
            Console.WriteLine("Total de matriculados em EDF: "+ (totalMatrículasEDF));

        }
        
    }

}
