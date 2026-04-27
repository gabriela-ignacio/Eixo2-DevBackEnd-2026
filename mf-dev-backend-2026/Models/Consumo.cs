using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2026.Models
{
    
    [Table ("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "A descrição é obrigatória.")]
        [Display (Name = "Descrição")]
        public string Descricao { get; set; }

        [Required (ErrorMessage = "A data é obrigatória.")]
        public DateTime Data { get; set; }

        [Required (ErrorMessage = "O valor é obrigatório.")]
        public decimal Valor { get; set; }

        [Required (ErrorMessage = "A quilometragem é obrigatória.")]
        [Display (Name = "Quilometragem")]
        public int Km { get; set; }

        [Display (Name = "Tipo de Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [Required (ErrorMessage = "Obrigatório informar o veículo.")]
        [Display (Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey ("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    // Enumeração para os tipos de combustível
    // Esta enumeração pode ser expandida conforme necessário para incluir outros tipos de combustível
    public enum TipoCombustivel
    {
        Gasolina,
        Diesel,
        Etanol,
        GNV,
        Eletrico
    }
}
