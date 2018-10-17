namespace KrauserTv.Forms
{
    partial class FrmLinksNuevo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Estatus = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbServidor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtaDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTemporada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbCapitulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSerie = new System.Windows.Forms.ComboBox();
            this.Servidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtaDetalles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Estatus);
            this.groupBox1.Controls.Add(this.CmbStatus);
            this.groupBox1.Controls.Add(this.TxtLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbServidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Estatus
            // 
            this.Estatus.AutoSize = true;
            this.Estatus.Location = new System.Drawing.Point(3, 142);
            this.Estatus.Name = "Estatus";
            this.Estatus.Size = new System.Drawing.Size(58, 18);
            this.Estatus.TabIndex = 11;
            this.Estatus.Text = "Estado";
            // 
            // CmbStatus
            // 
            this.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.CmbStatus.Location = new System.Drawing.Point(9, 163);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(278, 26);
            this.CmbStatus.TabIndex = 10;
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(6, 108);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(278, 26);
            this.TxtLink.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Servidor";
            // 
            // CmbServidor
            // 
            this.CmbServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServidor.FormattingEnabled = true;
            this.CmbServidor.Location = new System.Drawing.Point(6, 45);
            this.CmbServidor.Name = "CmbServidor";
            this.CmbServidor.Size = new System.Drawing.Size(278, 26);
            this.CmbServidor.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtaDetalles);
            this.groupBox2.Location = new System.Drawing.Point(333, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // DtaDetalles
            // 
            this.DtaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Servidor,
            this.Link});
            this.DtaDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtaDetalles.Location = new System.Drawing.Point(3, 22);
            this.DtaDetalles.Name = "DtaDetalles";
            this.DtaDetalles.Size = new System.Drawing.Size(476, 195);
            this.DtaDetalles.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Location = new System.Drawing.Point(569, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(16, 20);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 35);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.CmbTemporada);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.CmbCapitulo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.CmbSerie);
            this.groupBox4.Location = new System.Drawing.Point(11, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(801, 92);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Temporada";
            // 
            // CmbTemporada
            // 
            this.CmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTemporada.FormattingEnabled = true;
            this.CmbTemporada.Location = new System.Drawing.Point(368, 37);
            this.CmbTemporada.Name = "CmbTemporada";
            this.CmbTemporada.Size = new System.Drawing.Size(197, 26);
            this.CmbTemporada.TabIndex = 18;
            this.CmbTemporada.SelectedValueChanged += new System.EventHandler(this.CmbTemporada_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Capitulo";
            // 
            // CmbCapitulo
            // 
            this.CmbCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCapitulo.FormattingEnabled = true;
            this.CmbCapitulo.Location = new System.Drawing.Point(574, 37);
            this.CmbCapitulo.Name = "CmbCapitulo";
            this.CmbCapitulo.Size = new System.Drawing.Size(207, 26);
            this.CmbCapitulo.TabIndex = 16;
            this.CmbCapitulo.SelectedValueChanged += new System.EventHandler(this.CmbCapitulo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Serie";
            // 
            // CmbSerie
            // 
            this.CmbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSerie.FormattingEnabled = true;
            this.CmbSerie.Location = new System.Drawing.Point(13, 37);
            this.CmbSerie.Name = "CmbSerie";
            this.CmbSerie.Size = new System.Drawing.Size(349, 26);
            this.CmbSerie.TabIndex = 14;
            this.CmbSerie.SelectedValueChanged += new System.EventHandler(this.CmbSerie_SelectedValueChanged);
            // 
            // Servidor
            // 
            this.Servidor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servidor.DataPropertyName = "nombreserver";
            this.Servidor.HeaderText = "Servidor";
            this.Servidor.Name = "Servidor";
            // 
            // Link
            // 
            this.Link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Link.DataPropertyName = "link";
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // FrmLinksNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 408);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLinksNuevo";
            this.Text = "Nuevo enlace";
            this.Load += new System.EventHandler(this.FrmLinksNuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtaDetalles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Estatus;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbServidor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtaDetalles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTemporada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbCapitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
    }
}