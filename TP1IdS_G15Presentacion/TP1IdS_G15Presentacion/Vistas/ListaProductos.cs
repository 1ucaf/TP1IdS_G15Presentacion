using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1IdS_G15Presentacion.ServiceReference1;

namespace TP1IdS_G15Presentacion.Vistas
{
    public partial class ListaProductos : Form
    {
        public ListaProductos()
        {
            InitializeComponent();
        }

        private Wrapper.Autorizacion _Ticket;

        private void GetTicket()
        {
            var webReference = new Wrapper.LoginServiceClient();
            _Ticket = webReference.SolicitarAutorizacion("40CA85E4-283F-4C8B-BD07-2E60FE5354ED");
            dataGridView2.DataSource = _Ticket;
            MessageBox.Show(_Ticket.Sign);
        }

        private void FE()
        {
            var webReference = new AFIPWebService.ServiceSoapClient();
            var Auth = new AFIPWebService.FEAuthRequest();
            Auth.Cuit = _Ticket.Cuit;
            Auth.Token = _Ticket.Token;
            Auth.Sign = _Ticket.Sign;

            var FECAERequest = new AFIPWebService.FECAERequest();

            var Cabecera = new AFIPWebService.FECAECabRequest();
            Cabecera.CantReg = 1;
            Cabecera.PtoVta = 15;
            Cabecera.CbteTipo = 1;
            FECAERequest.FeCabReq = Cabecera;

            var Det = new AFIPWebService.FECAEDetRequest();
            Det.Concepto = 1;
            Det.DocTipo = 80;
            Det.DocNro = 20418167093;
            Det.CbteDesde = 1;
            Det.CbteHasta = 1;
            Det.CbteFch = "20220107";
            Det.ImpTotal = 0;
            Det.ImpTotConc = 0;
            Det.ImpNeto = 0;
            Det.ImpOpEx = 0;
            Det.ImpTrib = 0;
            Det.ImpIVA = 0;
            Det.MonId = "PES";
            Det.MonCotiz = 1;

            FECAERequest.FeDetReq = new AFIPWebService.FECAEDetRequest[] { Det };

            var Response = webReference.FECAESolicitar(Auth, FECAERequest);

            MessageBox.Show(Response.FeDetResp[0].Resultado);
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            //var webReference = new ServiceReference1.WebService1SoapClient();
            //var productosFromService = webReference.GetProductos();

            //List<object> productos = new List<object>();
            //productosFromService.ToList().ForEach((producto) =>
            //{
            //    var p = new
            //    {
            //        CodigoDeBarra = producto.CodigoDeBarra,
            //        Costo = producto.Costo,
            //        Descripcion = producto.Descripcion,
            //        Marca = producto.Marca.Descripcion,
            //        MargenDeGanancia = producto.MargenDeGanancia,
            //        PorcentajeIVA = producto.PorcentajeIVA,
            //        Rubro = producto.Rubro.Descripcion
            //    };
            //    productos.Add(p);
            //});
            //dataGridView1.DataSource = productos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTicket();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FE();
        }
    }
}
