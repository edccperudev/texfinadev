﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Co;
using Texfina.BOQry.TJ;

using Texfina.Entity.Sy;
using Texfina.DOQry.Sy;

//using Texfina.BOQry.Co;
//using Texfina.Core.Web;
//using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class FrmTejido_mnt : Form
    {
        public FrmTejido_mnt()
        {
            InitializeComponent();
            Permisos();
            CargarCombo();
        }


        private void Permisos()
        {
            try
            {

                string Usu = frmLogin.d.idUser;
                string menu = "04";
                string ifFormulario = "0006";



                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = Usu;
                u.IdModulo = menu;
                u.Id_formulario = ifFormulario;

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);

                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnCopiar.Enabled = bool.Parse(usuarioo._btnCopiar);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
               
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }


        private void CargarCombo()
        {
            WebHelper.LoadListControl3(cbMoneda, BTablaGeneral.tablaGeneral("016"));
            cbMoneda.SelectedIndex = -1;
            WebHelper.LoadListControl3(cbUmCompra, BTablaGeneral.tablaGeneral("020"));
            cbUmCompra.SelectedIndex = -1;
            WebHelper.LoadListControl3(cbUmConsumo, BTablaGeneral.tablaGeneral("022"));
            cbUmConsumo.SelectedIndex = -1;
            //WebHelper.LoadListControl3(cbGrupo, BFamilia.GetListFill_Qry01_(11, wfChgEmpPer.datos.idEmpresa));
            WebHelper.LoadListControl3(cbGrupo, BFamilia.GetListFill_Qry01_(11, wfChgEmpPer.datos.idEmpresa));
            cbGrupo.SelectedIndex = -1;
            
            
        }

         private void mCargarDatos()
        {
            try
            {

                EProducto oProd = new EProducto();

                if (txtcodprod.Text != "")
                {
                    oProd.Id_producto = txtcodprod.Text;
                }
                else
                {
                    oProd.Id_producto = txtidProducto.Text;
                }


                //oProd.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                oProd.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                List<EProducto> oListDato = BTejido.MG_Tejido_qry06(oProd);

                //if (oListDato.Count > 0)
                //{
                string val = oListDato[0].existe;

                if (val == "0")
                {



                    if (!string.IsNullOrEmpty(txtcodprod.Text))
                    {
                        EProducto oProducto = new EProducto();


                        oProducto.Id_producto = txtcodprod.Text.Trim();

                        //oProducto.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        oProducto.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                        EProducto oBtienePD = new EProducto();
                        oBtienePD = BTejido.mListarTejido(oProducto);

                        txtidProducto.Text = oBtienePD.Id_producto.ToString().Trim();
                        txtproducto.Text = oBtienePD.Ds_producto.ToString().Trim();
                        txtalias.Text = oBtienePD.Ds_prodalias.ToString().Trim();

                        cbGrupo.SelectedValue = oBtienePD.Id_grupo.ToString().Trim();

                        //WebHelper.LoadListControl3(cbFamilia, BFamilia.GetListFill_Qry02_(12, cbGrupo.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));
                        WebHelper.LoadListControl3(cbFamilia, BFamilia.GetListFill_Qry02_(12, cbGrupo.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));

                        cbFamilia.SelectedValue = oBtienePD.Id_familia.ToString().Trim();

                        //WebHelper.LoadListControl3(cbSubFamilia, BFamilia.GetListFill_Qry03_(13, cbGrupo.SelectedValue.ToString(), cbFamilia.SelectedValue.ToString().Trim(), wfChgEmpPer.datos.idEmpresa));
                        WebHelper.LoadListControl3(cbSubFamilia, BFamilia.GetListFill_Qry03_(13, cbGrupo.SelectedValue.ToString(), cbFamilia.SelectedValue.ToString().Trim(), wfChgEmpPer.datos.idEmpresa));


                        cbSubFamilia.SelectedValue = oBtienePD.Id_subfami.ToString().Trim();

                        cbMoneda.SelectedValue = oBtienePD.Id_vmoneda.ToString().Trim();
                        txtvalRep.Text = oBtienePD.Mt_valrepo.ToString().Trim();
                        cbUmCompra.SelectedValue = oBtienePD.Id_vunimed.ToString().Trim();
                        cbUmConsumo.SelectedValue = oBtienePD.Id_vunicons.ToString().Trim();
                        txtFacEquev.Text = oBtienePD.Nu_facequiv.ToString().Trim();
                        txtTgasto.Text = oBtienePD.Id_tipogsto.ToString().Trim();
                        txtdsGasto.Text = oBtienePD.ds_tipogsto.ToString().Trim();
                        txtCodFox.Text = oBtienePD.Id_prodFOX.ToString().Trim();

                        string HiddActivo = oBtienePD.St_activo.Trim();
                        string Hiddigv = oBtienePD.St_igvisc.Trim();

                        if ((Hiddigv) == "1")
                        {
                            chkigv.Checked = true;
                        }
                        else
                        {
                            chkigv.Checked = false;

                        }

                        if ((HiddActivo) == "1")
                        {
                            chkactivo.Checked = true;
                        }
                        else
                        {
                            chkactivo.Checked = false;
                        }

                        List<EProdXUnd> lstoc = new List<EProdXUnd>();
                        EProdXUnd prod = new EProdXUnd();

                        prod.Id_producto = txtcodprod.Text;
                        prod.Id_Empresa = wfChgEmpPer.datos.idEmpresa;//wfChgEmpPer.datos.idEmpresa;


                        dgTejido.DataSource = BTejido.mListarTejido(prod);




                    }



                }

                else
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Nuevo();

                }
            }
            catch (Exception ex)
            {

            }

     
        }



         private void Deshabilitar(GroupBox grupo)
         {


             foreach (Control c in grupo.Controls)
             {

                 if (c is TextBox)
                 {

                     c.Enabled = false;


                     this.txtidProducto.Focus();

                 }

                 else if (c is ComboBox)
                 {
                     c.Enabled = false;


                     this.txtidProducto.Focus();

                 }

             }
         }

         private void Habilitar(GroupBox grupo)
         {
             //txtnu_oc.Text = "";

             foreach (Control c in grupo.Controls)
             {

                 if (c is TextBox)
                 {

                     c.Enabled = true;


                     this.txtidProducto.Focus();

                 }
                 else if (c is ComboBox)
                 {
                     c.Enabled = true;


                     this.txtidProducto.Focus();

                 }
             }
         }

         int ancho, alto;

        private void Frmproducto_mnt_Load(object sender, EventArgs e)
        {
            
            ancho = this.Width;
            alto = this.Height;
            
            Deshabilitar(groupBox1);
            Deshabilitar(groupBox2);

        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //WebHelper.LoadListControl3(cbFamilia, BFamilia.GetListFill_Qry02_(12, cbGrupo.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));
                WebHelper.LoadListControl3(cbFamilia, BFamilia.GetListFill_Qry02_(12, cbGrupo.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));
                cbFamilia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
           
        }

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //WebHelper.LoadListControl3(cbSubFamilia, BFamilia.GetListFill_Qry03_(13, cbGrupo.SelectedValue.ToString(),cbFamilia.SelectedValue.ToString(),wfChgEmpPer.datos.idEmpresa));
            WebHelper.LoadListControl3(cbSubFamilia, BFamilia.GetListFill_Qry03_(13, cbGrupo.SelectedValue.ToString(), cbFamilia.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));
            cbSubFamilia.SelectedIndex = -1;
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtalias.Focus();
            }
        }

        private void txtalias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbGrupo.Focus();
            }
        }

        private void cbGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbFamilia.Focus();
            }
        }

        private void cbFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbSubFamilia.Focus();
            }
        }

        private void cbSubFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbMoneda.Focus();
            }
        }

        private void cbMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtvalRep.Focus();
            }
        }

        private void txtvalRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                cbUmCompra.Focus();
            }
            
            
           
        }

        private void cbUmCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbUmConsumo.Focus();
            }
        }

        private void cbUmConsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFacEquev.Focus();
            }
        }

        private void txtFacEquev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtTgasto.Focus();
            }
            
            
           
        }

        private void txtTgasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsGasto.Focus();
            }
        }

        private void txtdsGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        List<EProdXUnd> SalvarDatos = new List<EProdXUnd>();

        private void mSalvarDatosGrilla()
        {
            try
            {
                //recorre la cantidad de items, por cada item la entidad oAsigHorario va almacenando , 
                //esto para que data que se va ingresando en la grilla no se pierda

                List<EProdXUnd> lstSalvarDatos = new List<EProdXUnd>();

                for (int i = 0; dgTejido.Rows.Count > i; i++)
                {
                    // la entidad almacena los items de la grilla 

                    EProdXUnd oProdXUnd = new EProdXUnd();

                    // verificar si los valores ingresados en la grilla estan en label o texbox como tambien en un dropdowlinst
                    oProdXUnd.Id_prodprese = dgTejido.Rows[i].Cells["txtIdPresen"].Value.ToString();
                    oProdXUnd.Ds_prodprese = dgTejido.Rows[i].Cells["txtPresentacion"].Value.ToString();
                    oProdXUnd.Nu_uniprese = Convert.ToInt16(dgTejido.Rows[i].Cells["txtUndPres"].Value);
                    oProdXUnd.Nu_umprese = Convert.ToInt16(dgTejido.Rows[i].Cells["txtUndMedida"].Value);
                    oProdXUnd.Qt_pesoneto = Convert.ToDecimal(dgTejido.Rows[i].Cells["txtPesoNeto"].Value);
                    oProdXUnd.Qt_pesobruto = Convert.ToDecimal(dgTejido.Rows[i].Cells["txtPesoBruto"].Value);
                    oProdXUnd.Mt_precio = Convert.ToDecimal(dgTejido.Rows[i].Cells["txtPrecio"].Value);

                    //añade los valores de la entidad a la lista de la entidad

                    lstSalvarDatos.Add(oProdXUnd);

                }
                // se crea una sesion para almacenar la lista que contiene los  datos.

                SalvarDatos = lstSalvarDatos;
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }


        private void btnNuevo_item_Click(object sender, EventArgs e)
        {



            List<EProdXUnd> lstProd = new List<EProdXUnd>();

            EProdXUnd prod = new EProdXUnd();

            //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
            string str = Convert.ToString(dgTejido.Rows.Count + 1);
            if (dgTejido.Rows.Count > 0)
            {
                //almacena en la entidad la informacion ingresada en la grilla
                //salva los datos, hace que cuando se de agregar no se pierda la informacion ya ingresada

                mSalvarDatosGrilla();
                lstProd = (List<EProdXUnd>)SalvarDatos;

                //lstAsigHorario = (List<AsignacionHorarioEnt>)(Session["SeslstSalvaDatos"]);
                //añade un registro mas en blaco

                prod.Id_prodprese = str.PadLeft(3, '0');
                prod.Ds_prodprese = "";
                prod.Nu_uniprese = 0;
                prod.Nu_umprese = 0;
                prod.Qt_pesoneto = 0;
                prod.Qt_pesobruto = 0;
                prod.Mt_precio = Convert.ToDecimal("0.000");


                // muestra el item en blanco

                lstProd.Add(prod);

                dgTejido.DataSource = lstProd;

            }
            else
            {
                // Añande el primer item en blando de la grilla
                prod.Id_prodprese = str.PadLeft(3, '0');
                prod.Ds_prodprese = "";
                prod.Nu_uniprese = 0;
                prod.Nu_umprese = 0;
                prod.Qt_pesoneto = 0;

                prod.Qt_pesobruto = 0;
                prod.Mt_precio = Convert.ToDecimal("0.000");

                lstProd.Add(prod);

                //Muestra la grilla con un fila en blanco 

                dgTejido.DataSource = lstProd;

                //dgProducto.DataBind();


            }
      
        }

        private void btnDelete_item_Click(object sender, EventArgs e)
        {
            if (dgTejido.RowCount > 0)
            {
                mSalvarDatosGrilla();
                try
                {
                    EProdXUnd prodxUnd = new EProdXUnd();
                    var LblidPresentacion = dgTejido.CurrentRow.Cells["txtIdPresen"].Value;
                    prodxUnd.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                    prodxUnd.Id_producto = txtcodprod.Text;
                    prodxUnd.Id_prodprese = LblidPresentacion.ToString();
                    BProdXUnd.ProdXUnd_mmt03(prodxUnd);
                }
                catch (Exception ex)
                {

                }
                int u = dgTejido.CurrentCell.RowIndex;
                List<EProdXUnd> lsListadoActual = (List<EProdXUnd>)SalvarDatos;
                lsListadoActual.RemoveAt(u);
                SalvarDatos = lsListadoActual;
                dgTejido.DataSource = lsListadoActual;
            }
            else
            { 

            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtproducto.Text != "" & cbFamilia.Text != "" & cbSubFamilia.Text != "")
            {
                Grabar();
            }
            else
            {
                MessageBox.Show("Faltan Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Int32 esIgv, esActivo;
        private void estadoIgv()
        {
            if (chkigv.Checked == true)
            {
                esIgv = 1;
            }
            else
            {
                esIgv = 0;
            }

        }
        private void estadoActivo()
        {
            if (chkactivo.Checked == true)
            {
                esActivo = 1;
            }
            else
            {
                esActivo = 0;
            }

        }


        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que dese Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            {
                if (result == DialogResult.OK)
                {

                    //try
                    //{
                        estadoIgv();
                        estadoActivo();

                        EProducto _prod = new EProducto();
                        //DropDownList ddl = new DropDownList();

                        _prod.Id_grupo = cbGrupo.SelectedValue.ToString();
                        _prod.Id_familia = cbFamilia.SelectedValue.ToString();
                        _prod.Id_subfami = cbSubFamilia.SelectedValue.ToString();
                   
                        //_prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                        _prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        //ddl.Items.Clear();


                        EProducto prod = new EProducto();

                        if (txtcodprod.Text == "")
                        {
                            List<Dato> oListDato = BTejido.getCodigo(_prod);
                            if (oListDato[0].id != "")
                       
                            {
                          
                                txtcodprod.Text = oListDato[0].id;

                            }
                            else
                            {
                                MessageBox.Show("El producto ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                   
                            txtcodprod.Text = oListDato[0].id;
                        }
                        else
                        {
               
                            prod.Id_producto = txtcodprod.Text;
                        }


                        if (txtcodprod.Text != "")
                        {

                            prod.Id_producto = txtcodprod.Text;

                            prod.Ds_producto = txtproducto.Text.Trim().ToUpper();
                            prod.Ds_prodalias = txtalias.Text.Trim().ToUpper();
                            prod.Id_grupo = cbGrupo.SelectedValue.ToString();
                            prod.Id_familia = cbFamilia.SelectedValue.ToString();
                            prod.Id_subfami = cbSubFamilia.SelectedValue.ToString();
                            prod.Id_vunimed = cbUmCompra.SelectedValue.ToString();
                            prod.Id_vunicons = cbUmConsumo.SelectedValue.ToString();
                            prod.Nu_facequiv = Convert.ToDecimal(txtFacEquev.Text);
                            prod.Id_vmoneda = cbMoneda.SelectedValue.ToString();
                            prod.Mt_valrepo = Convert.ToDecimal(txtvalRep.Text);
                            prod.St_igvisc = esIgv.ToString();
                            prod.St_activo = esActivo.ToString();
                            prod.Id_tipogsto = txtTgasto.Text;
                            prod.Id_ucrearec = frmLogin.d.id.ToLower(); // frmLogin.d.id;
                            prod.Id_uupdarec = frmLogin.d.id.ToLower();//frmLogin.d.id;
                            prod.St_anulado = "0";
                            //prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                            prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                            prod.Id_prodFOX = txtCodFox.Text;
                            BTejido.Tejido_mnt(prod);
                            

                            ///Detalle

                            EProdXUnd prodxUnd = new EProdXUnd();


                            for (int i = 0; dgTejido.Rows.Count > i; i++)
                            {
                                prodxUnd.Id_producto = txtcodprod.Text;

                                var Lblpds_IdProdprese = dgTejido.Rows[i].Cells["txtIdPresen"].Value;
                                var Lblpds_prodprese = dgTejido.Rows[i].Cells["txtPresentacion"].Value;
                                var Lblpnu_uniprese = dgTejido.Rows[i].Cells["txtUndPres"].Value;
                                var Lblpnu_umprese = dgTejido.Rows[i].Cells["txtUndMedida"].Value;
                                var Lblpqt_pesoneto = dgTejido.Rows[i].Cells["txtPesoNeto"].Value;
                                var Lblpqt_pesobruto = dgTejido.Rows[i].Cells["txtPesoBruto"].Value;
                                var Lblpmt_precio = dgTejido.Rows[i].Cells["txtPrecio"].Value;

                                prodxUnd.Id_prodprese = Lblpds_IdProdprese.ToString();
                                prodxUnd.Ds_prodprese = Lblpds_prodprese.ToString();
                                prodxUnd.Nu_uniprese = Convert.ToInt16(Lblpnu_uniprese);
                                prodxUnd.Nu_umprese = Convert.ToInt16(Lblpnu_umprese);
                                prodxUnd.Qt_pesoneto = Convert.ToDecimal(Lblpqt_pesoneto);
                                prodxUnd.Qt_pesobruto = Convert.ToDecimal(Lblpqt_pesobruto);
                                prodxUnd.Mt_precio = Convert.ToDecimal(Lblpmt_precio);
                                prodxUnd.Id_ucrearec = frmLogin.d.id.ToLower();//frmLogin.d.id;
                                prodxUnd.Id_uupdarec = frmLogin.d.id.ToLower();//frmLogin.d.id;
                                prodxUnd.Id_Empresa = wfChgEmpPer.datos.idEmpresa;//wfChgEmpPer.datos.idEmpresa;
                                
                                BTejido.TejidoDet_mmt(prodxUnd);

                            }

                            MessageBox.Show(txtcodprod.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {


                        }



                    //}
                    //catch (Exception ex)
                    //{

                    //}

                }
                else if (result == DialogResult.Cancel)
                {

                }

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            FrmTipoGasto_qry frmp = new FrmTipoGasto_qry();
            frmp.pasard += new FrmTipoGasto_qry.pasar(ejecutarTGasto);
            frmp.ShowDialog();
          
        }

        public void ejecutarTGasto(ETipGasto tg)
        {
            txtTgasto.Text = tg.Id_tipogsto;
            txtdsGasto.Text = tg.Ds_tipogsto;
        }

        private void txtvalRep_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtFacEquev_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmTejido_qry frmp = new FrmTejido_qry();
            frmp.pasard += new FrmTejido_qry.pasar(ejecutarProd);
            frmp.ShowDialog();
        
        }
        public void ejecutarProd(EDetProducto prd)
        {
            txtcodprod.Text = prd._Codigo;
            mCargarDatos();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtcodprod.Text = "";
            txtidProducto.Text = "";
            txtCodFox.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Nuevo();
        }


        private void Nuevo()
        {
            Limpiar(groupBox1);
            txtvalRep.Text = "0.00";
            txtFacEquev.Text = "1.00";
            //dgTejido.Rows.Clear();
            NuevoItem();

            Habilitar(groupBox1);
            txtCodFox.Focus();
        }

        private void NuevoItem()
        {

            List<EProdXUnd> lstProd = new List<EProdXUnd>();

            EProdXUnd prod = new EProdXUnd();

            //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
            //string str = Convert.ToString(dgProducto.Rows.Count + 1);

            // Añande el primer item en blando de la grilla
            prod.Id_prodprese = "001";
            prod.Ds_prodprese = "";
            prod.Nu_uniprese = 0;
            prod.Nu_umprese = 0;
            prod.Qt_pesoneto = 0;

            prod.Qt_pesobruto = 0;
            prod.Mt_precio = Convert.ToDecimal("0.000");

            lstProd.Add(prod);

            //Muestra la grilla con un fila en blanco 

            dgTejido.DataSource = lstProd;
        }

        private void Limpiar(GroupBox grupo)
        {
            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";

                    this.txtproducto.Focus();
                }
            }
        }

        private void Frmproducto_mnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Limpiar(groupBox1);
                txtvalRep.Text = "0.00";
                txtFacEquev.Text = "1.00";
                //dgProducto.Rows.Clear();
                NuevoItem();
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {

                Grabar();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                //Frmproducto_qry frmp = new Frmproducto_qry();
                //frmp.pasard += new Frmproducto_qry.pasar(ejecutarProd);
                //frmp.ShowDialog();
            }
        }

        private void txtidProducto_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1)
            //{
            //    Frmproducto_qry frmp = new Frmproducto_qry();
            //    frmp.pasard += new Frmproducto_qry.pasar(ejecutarProd);
            //    frmp.ShowDialog();
            //}
        }

        private void txtTgasto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmTipoGasto_qry frmp = new FrmTipoGasto_qry();
                frmp.pasard += new FrmTipoGasto_qry.pasar(ejecutarTGasto);
                frmp.ShowDialog();
            }
        }

        private void Frmproducto_mnt_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(groupBox1);
        }

        private void txtidProducto_KeyPress(object sender, KeyPressEventArgs e)
        {          

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcodprod.Text = txtidProducto.Text;
                mCargarDatos();

            }
        }

        private void txtCodFox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtproducto.Focus();
            
            }
        }

     }



      

    
}
