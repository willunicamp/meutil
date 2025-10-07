namespace Entidades
{
    /// <summary>
    /// Representa uma disciplina oferecida pelo colégio.
    /// Esta é uma classe de modelo/entidade padrão.
    /// </summary>
    public class Disciplina
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; } // Em horas


        /// Construtor para criar uma nova disciplina com dados iniciais.
        public Disciplina(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }

        /// Sobrescrevendo o método ToString para exibir o nome da disciplina.
        /// Isso é muito útil para preencher componentes de UI como ComboBoxes e ListBoxes.
        public override string ToString()
        {
            return this.Nome;
        }
    }
}