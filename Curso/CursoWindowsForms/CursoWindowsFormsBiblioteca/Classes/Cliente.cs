using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "O nome é obrigatório.")]
            [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome deve possuir um mínimo de 2 a 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "O nome deve possuir um máximo de 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "O nome da mãe é obrigatório.")]
            [StringLength(50, MinimumLength = 2, ErrorMessage = "O nome da mãe deve possuir um mínimo de 2 a 50 caracteres.")]
            public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "O CPF é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
            [StringLength(11, MinimumLength = 1, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "O Gênero é obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "O CEP é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP somente aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "O Logradouro é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro pode ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            [StringLength(100, ErrorMessage = "Complemento pode ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "O Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro pode ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório.")]
            [StringLength(50, ErrorMessage = "Cidade pode ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O Estado é obrigatório.")]
            [StringLength(50, ErrorMessage = "Estado pode ter no máximo 50 caracteres.")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "O Tefelone é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Telefone somente aceita valores numéricos.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar é obrigatório.")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda Familiar deve ser um valor positivo.")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if(this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");
                }
                
                if(this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido estiver desmarcada. ");
                    }
                }

                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if(validaCPF == false)
                {
                    throw new Exception("CPF Inválido");
                }

            }

            public class List
            {
                public List<Unit> ListUnit { get; set; }
            }
        }
    }
}