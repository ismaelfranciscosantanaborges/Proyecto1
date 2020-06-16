using System.ComponentModel;

namespace ProyectoWeb.Models
{
    public enum ETipoEmpleado
    {
        [Description("Full Time")] FullTime = 1, [Description("Part Time")] PartTime, Freelancer
    }
}