using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Examen_Mvvm.ViewModels
{
    public partial class DesViewModels : ObservableObject
    {
        public class Producto
        {
            public double Precio { get; set; }
        }

        private ObservableCollection<Producto> _productos = new();
        public ObservableCollection<Producto> Productos
        {
            get => _productos;
            set => SetProperty(ref _productos, value);
        }

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double total;

        [RelayCommand]
        private void Calcular()
        {
            Subtotal = Productos.Sum(p => p.Precio);
            Descuento = CalcularDescuento(Subtotal);
            Total = Subtotal - Descuento;
        }

        private double CalcularDescuento(double subtotal)
        {
            if (subtotal >= 10000)
                return subtotal * 0.30;
        }

        [RelayCommand]
        private void Limpiar()
        {
            Productos.Clear();
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}