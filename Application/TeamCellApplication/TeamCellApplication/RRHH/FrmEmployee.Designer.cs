﻿namespace TeamCellApplication.RRHH
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deBirths = new DevExpress.XtraEditors.DateEdit();
            this.cbCity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCardIndentificador = new DevExpress.XtraEditors.TextEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtSecondSurname = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtFirstSurname = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtSecondName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.seIdEmpleado = new DevExpress.XtraEditors.SpinEdit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBirths.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardIndentificador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seIdEmpleado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros De Empleado";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 509);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.seIdEmpleado);
            this.tabPage1.Controls.Add(this.lblEmpleado);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.deBirths);
            this.tabPage1.Controls.Add(this.cbCity);
            this.tabPage1.Controls.Add(this.txtCardIndentificador);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.txtSecondSurname);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtFirstSurname);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.txtSecondName);
            this.tabPage1.Controls.Add(this.labelControl2);
            this.tabPage1.Controls.Add(this.txtFirstname);
            this.tabPage1.Controls.Add(this.labelControl7);
            this.tabPage1.Controls.Add(this.labelControl1);
            this.tabPage1.Controls.Add(this.labelControl6);
            this.tabPage1.Controls.Add(this.labelControl3);
            this.tabPage1.Controls.Add(this.labelControl5);
            this.tabPage1.Controls.Add(this.labelControl4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1025, 483);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Detalles Empleado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleado.Location = new System.Drawing.Point(311, 53);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(202, 29);
            this.lblEmpleado.TabIndex = 23;
            this.lblEmpleado.Text = "Nuevo Empleado";
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
            // deBirths
            // 
            this.deBirths.EditValue = null;
            this.deBirths.Location = new System.Drawing.Point(239, 214);
            this.deBirths.Name = "deBirths";
            this.deBirths.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirths.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirths.Size = new System.Drawing.Size(174, 20);
            this.deBirths.TabIndex = 19;
            // 
            // cbCity
            // 
            this.cbCity.Location = new System.Drawing.Point(595, 254);
            this.cbCity.Name = "cbCity";
            this.cbCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCity.Size = new System.Drawing.Size(174, 20);
            this.cbCity.TabIndex = 13;
            // 
            // txtCardIndentificador
            // 
            this.txtCardIndentificador.Location = new System.Drawing.Point(595, 208);
            this.txtCardIndentificador.Name = "txtCardIndentificador";
            this.txtCardIndentificador.Size = new System.Drawing.Size(174, 20);
            this.txtCardIndentificador.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnClear.AppearanceHovered.Options.UseBackColor = true;
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(669, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 41);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Limpiar";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSecondSurname
            // 
            this.txtSecondSurname.Location = new System.Drawing.Point(595, 157);
            this.txtSecondSurname.Name = "txtSecondSurname";
            this.txtSecondSurname.Size = new System.Drawing.Size(174, 20);
            this.txtSecondSurname.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(433, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 41);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstSurname
            // 
            this.txtFirstSurname.Location = new System.Drawing.Point(239, 160);
            this.txtFirstSurname.Name = "txtFirstSurname";
            this.txtFirstSurname.Size = new System.Drawing.Size(174, 20);
            this.txtFirstSurname.TabIndex = 9;
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
            this.btnEdit.Location = new System.Drawing.Point(551, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 41);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Editar";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(595, 111);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(174, 20);
            this.txtSecondName.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(469, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Segundo Nombre";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(239, 111);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(174, 20);
            this.txtFirstname.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(469, 258);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 18);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Ciudad";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(118, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Primer Nombre";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(469, 215);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "No.Cedula";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(115, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Primer Apellido";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(115, 212);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 18);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Fecha Nac.";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(467, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(106, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Segundo Apellido";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1025, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Empleados Activo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1025, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista de Empleados Inactivos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // seIdEmpleado
            // 
            this.seIdEmpleado.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seIdEmpleado.Location = new System.Drawing.Point(419, 109);
            this.seIdEmpleado.Name = "seIdEmpleado";
            this.seIdEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seIdEmpleado.Size = new System.Drawing.Size(42, 20);
            this.seIdEmpleado.TabIndex = 24;
            this.seIdEmpleado.EditValueChanged += new System.EventHandler(this.seIdEmpleado_EditValueChanged);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 547);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee2";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deBirths.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCardIndentificador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecondName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seIdEmpleado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit cbCity;
        private DevExpress.XtraEditors.TextEdit txtCardIndentificador;
        private DevExpress.XtraEditors.TextEdit txtSecondSurname;
        private DevExpress.XtraEditors.TextEdit txtFirstSurname;
        private DevExpress.XtraEditors.TextEdit txtSecondName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFirstname;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deBirths;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpleado;
        private DevExpress.XtraEditors.SpinEdit seIdEmpleado;
    }
}