namespace Entidades
{
    // INTERFACE: Define um contrato de métodos que a classe deve implementar.
    public interface IRepositorio
    {
        void Salvar();
        void Excluir();
        void Atualizar();
    }
}