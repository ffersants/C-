using System;
using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entities
{
    public class BaseEntity
    {
        // coloca a propriedade Id como uma chave primária
        [Key]
        public Guid Id { get; set; }
        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdateAt { get; set; }
    }
}
