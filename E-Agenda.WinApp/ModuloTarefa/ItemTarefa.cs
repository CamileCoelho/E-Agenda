namespace E_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class ItemTarefa 
    {
        public bool concluido { get; set; }
        public string titulo { get; set; }

        public ItemTarefa()
        {
            
        }

        public ItemTarefa(string titulo)
        {
            this.titulo = titulo;
        }

        public void Concluir()
        {
            concluido = true;
        }

        public void Desmarcar()
        {
            concluido = false;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        public override string ToString()
        {
            return titulo;
        }
    }

}

