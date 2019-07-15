namespace TeamCellApplication.Product
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipoCosteo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbProvider = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCosteo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProvider.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros De Producto";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 509);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkEdit2);
            this.tabPage1.Controls.Add(this.checkEdit1);
            this.tabPage1.Controls.Add(this.cbTipoCosteo);
            this.tabPage1.Controls.Add(this.cbProvider);
            this.tabPage1.Controls.Add(this.lblEmpleado);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.cbCategory);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtname);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1025, 483);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Detalles Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkEdit2
            // 
            this.checkEdit2.EditValue = true;
            this.checkEdit2.Location = new System.Drawing.Point(676, 155);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "No";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 27;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(610, 155);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Si";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 26;
            // 
            // cbTipoCosteo
            // 
            this.cbTipoCosteo.Location = new System.Drawing.Point(595, 111);
            this.cbTipoCosteo.Name = "cbTipoCosteo";
            this.cbTipoCosteo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoCosteo.Size = new System.Drawing.Size(174, 20);
            this.cbTipoCosteo.TabIndex = 25;
            // 
            // cbProvider
            // 
            this.cbProvider.Location = new System.Drawing.Point(239, 209);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProvider.Size = new System.Drawing.Size(174, 20);
            this.cbProvider.TabIndex = 24;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(311, 53);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(193, 29);
            this.lblEmpleado.TabIndex = 23;
            this.lblEmpleado.Text = "Nuevo Producto";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(775, 351);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 41);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(-7, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 28);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 27);
            this.panel1.TabIndex = 20;
            // 
            // cbCategory
            // 
            this.cbCategory.Location = new System.Drawing.Point(239, 155);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCategory.Size = new System.Drawing.Size(174, 20);
            this.cbCategory.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(657, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 41);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Limpiar";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNew.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Appearance.Options.UseForeColor = true;
            this.btnNew.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnNew.AppearanceHovered.Options.UseBackColor = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(421, 351);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 41);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Guardar";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.AppearanceHovered.Options.UseBackColor = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(539, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 41);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Editar";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(469, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tipo de Costeo";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(239, 111);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(174, 20);
            this.txtname.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(118, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = " Nombre";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(115, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Categoria";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(115, 212);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Proveedor";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(467, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Impuesto";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1025, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Producto Activo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1025, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista de Productos Inactivos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 547);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCosteo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProvider.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoCosteo;
        private DevExpress.XtraEditors.ComboBoxEdit cbProvider;
        private System.Windows.Forms.Label lblEmpleado;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbCategory;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}