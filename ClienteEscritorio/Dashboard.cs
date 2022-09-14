using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscritorio
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private static ServiceReference2.WSNorthwindSoapClient servicio;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarShipp_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            servicio = new ServiceReference2.WSNorthwindSoapClient();
            dgvShipping.DataSource = servicio.ListarShippers().Tables[0];
            dgvProduct.DataSource = servicio.ListarProducts().Tables[0];
            dgvSupplier.DataSource = servicio.ListarSuppliers().Tables[0];
        }

        private void dgvShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregarShip_Click(object sender, EventArgs e)
        {
            string companyNameShipp = txtCompanyNameShipp.Text.ToString();
            string phoneCompany = txtPhoneShipp.Text.ToString();
            servicio.AgregarShippers(companyNameShipp, phoneCompany);
            dgvShipping.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnEliminarShipp_Click(object sender, EventArgs e)
        {
            string idShipper = txtIdShippers.Text.ToString();
            servicio.EliminarShippers(idShipper);
            dgvShipping.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnActualizarShipp_Click(object sender, EventArgs e)
        {
            string idShipper = txtIdShippers.Text.ToString();
            string companyNameShipp = txtCompanyNameShipp.Text.ToString();
            string phoneCompany = txtPhoneShipp.Text.ToString();
            servicio.ActualizarShippers(idShipper, companyNameShipp, phoneCompany);
            dgvShipping.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarProduct_Click(object sender, EventArgs e)
        {
            string productName = txtCompanyNameShipp.Text.ToString();
            string supplierId = txtSupplierIdProduct.Text.ToString();
            string categoryid = txtCategoryIdProduct.Text.ToString();
            string quantityUnit = txtQuantityPerUnit.Text.ToString();
            string unitPrice = txtUnitPriceProduct.Text.ToString();
            string unitInStock = txtUnitsInStock.Text.ToString();
            string unitOnOrder = txtUnitsOnOrder.Text.ToString();
            string recorderLevel = txtRecorderLevel.Text.ToString();
            string discontinued = txtDiscontinued.Text.ToString();

            servicio.AgregarProducts(productName, supplierId, categoryid, quantityUnit, unitPrice, unitInStock, unitOnOrder, recorderLevel, discontinued);
            dgvShipping.DataSource = servicio.ListarProducts().Tables[0];
        }

        private void btnEliminarProduct_Click(object sender, EventArgs e)
        {
            string idProduct = txtIdProduct.Text.ToString();
            servicio.EliminarProducts(idProduct);
            dgvShipping.DataSource = servicio.ListarProducts().Tables[0];
        }

        private void btnActualizarProduct_Click(object sender, EventArgs e)
        {
            string idProduct = txtIdProduct.Text.ToString();
            string productName = txtCompanyNameShipp.Text.ToString();
            string supplierId = txtSupplierIdProduct.Text.ToString();
            string categoryid = txtCategoryIdProduct.Text.ToString();
            string quantityUnit = txtQuantityPerUnit.Text.ToString();
            string unitPrice = txtUnitPriceProduct.Text.ToString();
            string unitInStock = txtUnitsInStock.Text.ToString();
            string unitOnOrder = txtUnitsOnOrder.Text.ToString();
            string recorderLevel = txtRecorderLevel.Text.ToString();
            string discontinued = txtDiscontinued.Text.ToString();
            servicio.ActualizarProducts(idProduct, productName, supplierId, categoryid, quantityUnit, unitPrice, unitInStock, unitOnOrder, recorderLevel, discontinued);
            dgvShipping.DataSource = servicio.ListarProducts().Tables[0];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idSupplier = txtSupplierId.Text.ToString();
            string companyName = txtCompanyNameSuppliers.Text.ToString();
            string contactName = txtContactNameSupplier.Text.ToString();
            string contactTitle = txtContactTitle.Text.ToString();
            string address = txtAddressSupplier.Text.ToString();
            string city = txtCitySupplier.Text.ToString();
            string region = txtRegionSupplier.Text.ToString();
            string postalCode = txtPostalcodeSuppliers.Text.ToString();
            string country = txtCountrySupplier.Text.ToString();
            string phone = txtPhoneSuppliers.Text.ToString();
            string fax = txtFaxSupplier.Text.ToString();
            string homePage = txtHomePageSupplier.Text.ToString();

            servicio.ActualizarSuppliers(idSupplier, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);
            dgvShipping.DataSource = servicio.ListarProducts().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyNameSuppliers.Text.ToString();
            string contactName = txtContactNameSupplier.Text.ToString();
            string contactTitle = txtContactTitle.Text.ToString();
            string address = txtAddressSupplier.Text.ToString();
            string city = txtCitySupplier.Text.ToString();
            string region = txtRegionSupplier.Text.ToString();
            string postalCode = txtPostalcodeSuppliers.Text.ToString();
            string country = txtCountrySupplier.Text.ToString();
            string phone = txtPhoneSuppliers.Text.ToString();
            string fax = txtFaxSupplier.Text.ToString();
            string homePage = txtHomePageSupplier.Text.ToString();
            servicio.AgregarSuppliers(companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage);
            dgvSupplier.DataSource = servicio.ListarSuppliers().Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idSupplier = txtSupplierId.Text.ToString();
            servicio.EliminarSuppliers(idSupplier);
            dgvSupplier.DataSource = servicio.ListarSuppliers().Tables[0];
        }
    }
}
