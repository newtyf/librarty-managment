using System;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public partial class FormReserveBook : Form
    {
        private Book _book;
        public FormReserveBook(Book book)
        {
            _book = book;
            InitializeComponent();
        }


        private void FormReserveBook_Load(object sender, EventArgs e)
        {
            idLabelReservar.Text = _book.Id;
            titleLabelReservar.Text = _book.Title;
            descripLabelReservar.Text = _book.Description;
            autorLabelReservar.Text = _book.Author;
            publLabelReservar.Text = _book.Publication;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionadaReservacion = dateTimePicker1.Value;
            DateTime fechaSeleccionadaDevolucion = dateTimePicker2.Value;
            DateTime fechaActual = DateTime.Now;
            
            if (fechaSeleccionadaReservacion < fechaActual || fechaSeleccionadaDevolucion < fechaActual.AddDays(1))
            {
                MessageBox.Show("Debe llenar las fechas mayor al dia actual");
                return;
            }

            if (fechaSeleccionadaDevolucion <= fechaSeleccionadaReservacion)
            {
                MessageBox.Show("La fecha de devolucion debe ser mayor a la fecha de reservacion");
                return;
            }

            int cant = ReserveManager.CurrentReserves.ContarNodos();
            reserve = new Reserve((cant + 1).ToString(), _book.Title, fechaSeleccionadaDevolucion.ToString(),
                fechaSeleccionadaReservacion.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
        
        public Reserve reserve { get; set; }
    }
}