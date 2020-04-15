using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Professor
{
    class GestaoDoProfessor
    {
        /*MetodosDoProfessor c = new MetodosDoProfessor();
        ArrayList m;

        public void menu()
        {

            do
            {
                Console.WriteLine(" ------MENU------\n" +
                                  "1.INTRODUZIR:...\n" +
                                  "2.IMPRIMIR:...\n" +
                                  "3.IMPRIMIR DADOS DOS PROFESSORES:...\n" +
                                  "4.SALARIO MEDIO:...\n" +
                                  "5.ACTUALIZAR SALARIO:...\n" +
                                  "6.Sair! \n");

                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1: c.introduzir(); break;
                    case 2: c.imprimir(m); break;
                    case 3: c.imprimir1(m); break;
                    case 4: c.salarioMed(m); break;
                    case 5: c.actualizaSal(m); break;
                    case 6: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Escolha uma das opçoes! [ 1/2/3/4/5/6 ]"); break;
                }

            } while (true);
        }*/

        public static void main(String [] args)
        {
            /*GestaoDoProfessor gestao = new GestaoDoProfessor();
            gestao.menu();*/
            MetodosDoProfessor z = new MetodosDoProfessor();
            z.menu();
        } 
    }
}
