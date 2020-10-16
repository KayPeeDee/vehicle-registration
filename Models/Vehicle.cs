using System;
using System.ComponentModel.DataAnnotations;

namespace CrudmvcApp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleRegNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfRegistration { get; set; }
        public string OwnerNationalIdNumber { get; set; }
        public decimal MonthlyInsuranceAmount { get; set; }
    }
}