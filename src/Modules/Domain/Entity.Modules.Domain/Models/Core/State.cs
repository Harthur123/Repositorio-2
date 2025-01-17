using NetDevPack.Domain;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace Entity.Modules.Domain.Models.Core
{
    public class State : Entity, IAggregateRoot
    {
        private readonly List<Country> _countries;

        public State(Guid id, string uf, string stateName)
        {
            Id = id;
            _countries = new List<Country>();
            UF = uf;
            StateName = stateName;
        }
        
        public State() { }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [StringLength(100)]
        public string? StateName { get; private set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório.")]
        [MaxLength(2)]
        public string? UF { get; private set; }

        public Country Country { get; set; }

        public Guid CountryId { get; private set; }

        public IReadOnlyCollection<Country> Countries => _countries.AsReadOnly();


    }
}