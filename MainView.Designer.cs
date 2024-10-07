using MtgApiManager.Lib.Model;
using MtgCollectionCore.model;
using MtgCollectionCore.service;

namespace MtgCollectionCore
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewColeccion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBusqueda = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOriginalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.tabPageColeccion = new System.Windows.Forms.TabPage();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageBuscar);
            this.tabControlPrincipal.Controls.Add(this.tabPageColeccion);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1137, 627);
            this.tabControlPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlPrincipal.TabIndex = 2;
            // 
            // tabPageBuscar
            // 
            this.tabPageBuscar.Controls.Add(this.buttonGuardar);
            this.tabPageBuscar.Controls.Add(this.panel1);
            this.tabPageBuscar.Controls.Add(this.buttonBuscar);
            this.tabPageBuscar.Controls.Add(this.textBoxBuscar);
            this.tabPageBuscar.Controls.Add(this.labelNombre);
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 24);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscar.Size = new System.Drawing.Size(1129, 599);
            this.tabPageBuscar.TabIndex = 0;
            this.tabPageBuscar.Text = "Buscar";
            this.tabPageBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuardar.Location = new System.Drawing.Point(1031, 27);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(90, 30);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewColeccion);
            this.panel1.Controls.Add(this.dataGridViewBusqueda);
            this.panel1.Location = new System.Drawing.Point(8, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 498);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewColeccion
            // 
            this.dataGridViewColeccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewColeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewColeccion.Location = new System.Drawing.Point(573, 0);
            this.dataGridViewColeccion.Name = "dataGridViewColeccion";
            this.dataGridViewColeccion.RowTemplate.Height = 25;
            this.dataGridViewColeccion.Size = new System.Drawing.Size(540, 498);
            this.dataGridViewColeccion.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewBusqueda
            // 
            this.dataGridViewBusqueda.AllowUserToAddRows = false;
            this.dataGridViewBusqueda.AllowUserToDeleteRows = false;
            this.dataGridViewBusqueda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnOriginalType,
            this.ColumnRarity});
            this.dataGridViewBusqueda.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewBusqueda.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBusqueda.MultiSelect = false;
            this.dataGridViewBusqueda.Name = "dataGridViewBusqueda";
            this.dataGridViewBusqueda.ReadOnly = true;
            this.dataGridViewBusqueda.RowTemplate.Height = 25;
            this.dataGridViewBusqueda.Size = new System.Drawing.Size(573, 498);
            this.dataGridViewBusqueda.TabIndex = 0;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.DataPropertyName = "Name";
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 330;
            // 
            // ColumnOriginalType
            // 
            this.ColumnOriginalType.DataPropertyName = "OriginalType";
            this.ColumnOriginalType.HeaderText = "Tipo";
            this.ColumnOriginalType.Name = "ColumnOriginalType";
            this.ColumnOriginalType.ReadOnly = true;
            // 
            // ColumnRarity
            // 
            this.ColumnRarity.DataPropertyName = "Rarity";
            this.ColumnRarity.HeaderText = "Rareza";
            this.ColumnRarity.Name = "ColumnRarity";
            this.ColumnRarity.ReadOnly = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuscar.Location = new System.Drawing.Point(302, 28);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 30);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBuscar.Location = new System.Drawing.Point(82, 29);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(214, 29);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(8, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 21);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // tabPageColeccion
            // 
            this.tabPageColeccion.Location = new System.Drawing.Point(4, 24);
            this.tabPageColeccion.Name = "tabPageColeccion";
            this.tabPageColeccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageColeccion.Size = new System.Drawing.Size(1129, 599);
            this.tabPageColeccion.TabIndex = 1;
            this.tabPageColeccion.Text = "Colección";
            this.tabPageColeccion.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 627);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "MainView";
            this.Text = "MtgCollection";
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageBuscar.ResumeLayout(false);
            this.tabPageBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitializeEvents()
        {
            buttonBuscar.Click += ButtonBuscar_Click;
            buttonGuardar.Click += ButtonGuardar_Click;
            dataGridViewColeccion.DoubleClick += DataGridViewColeccion_DoubleClick;
            textBoxBuscar.KeyPress += TextBoxBuscar_KeyPress;
        }

        private void TextBoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Enter))
                ButtonBuscar_Click(sender, e);
        }

    

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CardService cardService = new CardService();

                if (textBoxBuscar.TextLength != 0 && !string.IsNullOrWhiteSpace(textBoxBuscar.Text))
                {
                    cardService.buscarPorNombreAsync(textBoxBuscar.Text, dataGridViewBusqueda);
                }
                else
                {
                    MessageBox.Show("inserta un nombre a buscar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewColeccion_DoubleClick(object sender, EventArgs e)
        {
           dataGridViewBusqueda.SelectedRows.Clear();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected internal TabControl tabControlPrincipal;
        protected internal TabPage tabPageBuscar;
        protected internal Button buttonGuardar;
        private Panel panel1;
        protected internal DataGridView dataGridViewColeccion;
        protected internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        protected internal DataGridView dataGridViewBusqueda;
        protected internal Button buttonBuscar;
        protected internal TextBox textBoxBuscar;
        protected internal Label labelNombre;
        protected internal TabPage tabPageColeccion;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnOriginalType;
        private DataGridViewTextBoxColumn ColumnRarity;
    }
}