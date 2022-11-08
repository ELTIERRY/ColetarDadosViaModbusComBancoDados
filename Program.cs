using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Programa6
{
    class Program
    {
        static void Main()
        {
            Criar();
            //Thread.Sleep(1000);
        }

        static void Listar()
        {
            using (var context = new ProgramaContext()) 
            {
                foreach(var item in context.DadosPrensas)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
            }
        }

        static void Criar()
        {
            using (var context = new ProgramaContext()) 
            {
                //ModelDadosPrensa std = new DadosPrensa("125","325");
                var std = new DadosPrensa()
                {
                  Prensa = 50, TemperaturaPlato01 = "103", TemperaturaPlato02 = "99"
                };

                context.DadosPrensas.Add(std);
                context.SaveChanges();
                AtualizarResumo(std);
            }
        }

        static void AtualizarResumo(DadosPrensa prensa)
        {
            using (var context = new ProgramaContext()) 
            {
                var resumo = context.ResumoPrensas.FirstOrDefault(x => x.Prensa == prensa.Prensa);
                if (resumo == null)
                {
                    resumo = new ResumoPrensa();
                    var resultado = Clonar(prensa, resumo);
                    resultado.Id = new int();
                    context.ResumoPrensas.Add(resultado);
                    context.SaveChanges();
                }
                else
                {   
                    int idx = resumo.Id;
                    var resultado = Clonar(prensa, resumo);
                    resultado.Id = idx;
                    context.ResumoPrensas.Update(resultado);
                    context.SaveChanges();
                }
            }
        }

        static void AtualizarResumo()
        {
            int id = 2;
            
            using (var context = new ProgramaContext()) 
            {
                DadosPrensa prensa = context.DadosPrensas.FirstOrDefault(x => x.Id == id);
                ResumoPrensa resumo = new ResumoPrensa();

                if (prensa != null)
                {
                    prensa.TemperaturaPlato01 = "65";
                    prensa.TemperaturaPlato02 = "99";  
                }
                else
                {
                    Console.WriteLine($"Não localizado");
                    return;
                }  

                // Clonar "prensa" para "resumo"    
                Clonar(prensa,resumo);
                context.UpdateRange(prensa, resumo);
                context.SaveChanges();
                
                Console.WriteLine($"{prensa.ToString()}");
            }
            
        }

        static void Deletar()
        {

        }

        static ResumoPrensa Clonar(DadosPrensa dado, ResumoPrensa resumo)
        {
            Type propType1 = dado.GetType();
            Type propType2 = resumo.GetType();
            foreach(var info in propType1.GetProperties())
            {
                propType2.GetProperty(info.Name)
                    .SetValue(resumo, info.GetValue(dado));
            }
            return resumo;
        }
    }

}