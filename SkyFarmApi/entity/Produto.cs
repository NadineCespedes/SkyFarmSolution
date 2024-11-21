namespace SkyFarmApi.entity
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string Bitmap { get; set; }

        public int? Quantidade { get; set; }
        public string Medida { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
    }
}
