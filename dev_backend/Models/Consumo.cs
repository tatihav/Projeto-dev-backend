using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_backend.Models
{
    [Table("Consumos")]

    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a descrição!")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar valor!")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Quilometragem!")]
        public int Km { get; set; }

        [Display(Name ="Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o Veículo!")]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Gás
    }
}
