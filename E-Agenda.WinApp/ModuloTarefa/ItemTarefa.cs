using E_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Agenda.WinApp.ModuloTarefa
{
    public class ItemTarefa 
    {
        public bool concluido { get; set; }
        public string titulo { get; set; }

        public void marcarConcluido()
        {
            concluido = true;
        }

        public void marcarPendente()
        {
            concluido = false;
        }
        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public override string ToString()
        {
            return titulo;
        }

        public void Concluir()
        {
            concluido = true;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public void Desmarcar()
        {
            concluido = false;
        }
    }

}

