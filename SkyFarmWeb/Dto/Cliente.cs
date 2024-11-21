namespace SkyFarmWeb.Dto
{
    public class Cliente
    {
        public Cliente() { }
        public DtoCliente dtoId(int id) {
            DtoCliente cl = new DtoCliente();
            cl.Id = id;
            return cl;
        }
    }
}
