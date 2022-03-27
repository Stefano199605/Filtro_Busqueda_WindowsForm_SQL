using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Models.Dao;
using CRUD.Models.Datos;
using CRUD.Views;
namespace CRUD.Controllers
{
    class ClienteController
    {
        ClienteView Vista;

        public ClienteController(ClienteView View)
        {
            Vista = View;
            //Inicializar los eventos
            Vista.Load += new EventHandler(ClienteList);
            Vista.btnBuscar.Click += new EventHandler(ClienteList);
            Vista.txtBuscar.TextChanged += new EventHandler(ClienteList);
        }

        private void ClienteList(object sender, EventArgs e)
        {
            ClienteDao db = new ClienteDao();
            Vista.dgvListado.DataSource = db.VerRegistros(Vista.txtBuscar.Text);

        }


    }
}
