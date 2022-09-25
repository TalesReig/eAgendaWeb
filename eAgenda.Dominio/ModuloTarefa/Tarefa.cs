using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio.ModuloTarefa
{
    [Serializable]
    public class Tarefa : EntidadeBase<Tarefa>
    {
        private List<ItemTarefa> itens;

        public Tarefa() : base()
        {
            Prioridade = PrioridadeTarefaEnum.Baixa;
            DataCriacao = DateTime.Now;
            itens = new List<ItemTarefa>();
        }

        public Tarefa(string t) : this()
        {
            Titulo = t;
            DataConclusao = null;
        }

        public string Titulo { get; set; }

        public PrioridadeTarefaEnum Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public List<ItemTarefa> Itens { get { return itens; } }
        public decimal PercentualConcluido { get; set; }


        public void CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
            {
                PercentualConcluido = 0;
                return;
            }

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            PercentualConcluido = Math.Round(percentualConcluido, 2);
        }

        public override string ToString()
        {
            var percentual = PercentualConcluido;

            if (DataConclusao.HasValue)
            {
                return $"Número: {Id}, Título: {Titulo}, Percentual: {percentual}, Prioridade: {Prioridade}, " +
                    $"Concluída: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Número: {Id}, Título: {Titulo}, Percentual: {percentual}, Prioridade: {Prioridade}";
        }

        public Tarefa Clonar()
        {
            return MemberwiseClone() as Tarefa;
        }

        public bool AdicionarItem(ItemTarefa item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
            {
                item.Tarefa = this;
                itens.Add(item);
                DataConclusao = null;

                CalcularPercentualConcluido();

                return true;
            }

            return false;
        }

        public void ConcluirItem(Guid itemId)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Id.Equals(itemId));

            itemTarefa?.Concluir();

            if (itens.All(x => x.Concluido))
                DataConclusao = DateTime.Now.Date;

            CalcularPercentualConcluido();
        }

        public void MarcarPendente(Guid itemId)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Id.Equals(itemId));

            itemTarefa?.MarcarPendente();

            CalcularPercentualConcluido();
        }

        public void RemoverItem(Guid itemId)
        {
            var itemTarefa = itens.Find(x => x.Id.Equals(itemId));

            itens.Remove(itemTarefa);

            CalcularPercentualConcluido();
        }

        public override void Atualizar(Tarefa registro)
        {
            Id = registro.Id;
            Titulo = registro.Titulo;
            Prioridade = registro.Prioridade;
        }

        public override bool Equals(object obj)
        {
            return obj is Tarefa tarefa &&
                   Id == tarefa.Id &&
                   Titulo == tarefa.Titulo &&
                   Prioridade == tarefa.Prioridade &&
                   DataCriacao.Date == tarefa.DataCriacao.Date &&
                   DataConclusao?.Date == tarefa.DataConclusao?.Date &&
                   PercentualConcluido == tarefa.PercentualConcluido;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo, Prioridade, DataCriacao, DataConclusao, PercentualConcluido);
        }
    }
}
