using System;
using System.ComponentModel.DataAnnotations;

namespace ModalityManager.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime AcquiredDate { get; set; }
        public string Modality { get; set; }

        public decimal Price { get; set; }

    }
}
