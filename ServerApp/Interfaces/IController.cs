namespace ServerApp.Interfaces
{
    internal interface IController<T>
    {
        public void CREATE(T entity);
        public T SELECT(int Id);
        public void DELETE(int Id);
        public void UPDATE(T entity);
    }
}
