﻿namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Extra
    {
        public Extra()
            => this.Vehicles = new HashSet<Vehicle>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ExtraNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
