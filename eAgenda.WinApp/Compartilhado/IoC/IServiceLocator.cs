namespace eAgenda.WinApp.Compartilhado.Ioc
{
    public interface IServiceLocator
    {
        T Get<T>() where T : ControladorBase;
    }
}
