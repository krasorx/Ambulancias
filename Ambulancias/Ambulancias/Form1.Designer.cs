namespace Ambulancias
{
    partial class Form1
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
            this.TbControl = new System.Windows.Forms.TabControl();
            this.Ambulancias = new System.Windows.Forms.TabPage();
            this.Emergencias = new System.Windows.Forms.TabPage();
            this.GrbControl = new System.Windows.Forms.GroupBox();
            this.TxbDesc = new System.Windows.Forms.TextBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.LtbAmbulancias = new System.Windows.Forms.ListBox();
            this.GrbControlEmer = new System.Windows.Forms.GroupBox();
            this.TxbCantEmAtendidas = new System.Windows.Forms.TextBox();
            this.Calendario2 = new System.Windows.Forms.MonthCalendar();
            this.LtbEmergencias = new System.Windows.Forms.ListBox();
            this.BtnEmerMen = new System.Windows.Forms.Button();
            this.LtbEmergencies = new System.Windows.Forms.ListBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxbTipo = new System.Windows.Forms.TextBox();
            this.TxbDate = new System.Windows.Forms.TextBox();
            this.TxbDir = new System.Windows.Forms.TextBox();
            this.TxbCode = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbControl.SuspendLayout();
            this.Ambulancias.SuspendLayout();
            this.Emergencias.SuspendLayout();
            this.GrbControl.SuspendLayout();
            this.GrbControlEmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbControl
            // 
            this.TbControl.Controls.Add(this.Ambulancias);
            this.TbControl.Controls.Add(this.Emergencias);
            this.TbControl.Location = new System.Drawing.Point(0, 0);
            this.TbControl.Name = "TbControl";
            this.TbControl.SelectedIndex = 0;
            this.TbControl.Size = new System.Drawing.Size(770, 446);
            this.TbControl.TabIndex = 1;
            // 
            // Ambulancias
            // 
            this.Ambulancias.Controls.Add(this.GrbControl);
            this.Ambulancias.Location = new System.Drawing.Point(4, 22);
            this.Ambulancias.Name = "Ambulancias";
            this.Ambulancias.Padding = new System.Windows.Forms.Padding(3);
            this.Ambulancias.Size = new System.Drawing.Size(762, 420);
            this.Ambulancias.TabIndex = 0;
            this.Ambulancias.Text = "Ambulancias";
            this.Ambulancias.UseVisualStyleBackColor = true;
            // 
            // Emergencias
            // 
            this.Emergencias.Controls.Add(this.GrbControlEmer);
            this.Emergencias.Location = new System.Drawing.Point(4, 22);
            this.Emergencias.Name = "Emergencias";
            this.Emergencias.Padding = new System.Windows.Forms.Padding(3);
            this.Emergencias.Size = new System.Drawing.Size(762, 272);
            this.Emergencias.TabIndex = 1;
            this.Emergencias.Text = "Emergencias";
            this.Emergencias.UseVisualStyleBackColor = true;
            // 
            // GrbControl
            // 
            this.GrbControl.BackColor = System.Drawing.Color.DimGray;
            this.GrbControl.Controls.Add(this.BtnEmerMen);
            this.GrbControl.Controls.Add(this.label4);
            this.GrbControl.Controls.Add(this.label3);
            this.GrbControl.Controls.Add(this.label2);
            this.GrbControl.Controls.Add(this.LblType);
            this.GrbControl.Controls.Add(this.TxbCode);
            this.GrbControl.Controls.Add(this.TxbDir);
            this.GrbControl.Controls.Add(this.TxbDate);
            this.GrbControl.Controls.Add(this.TxbTipo);
            this.GrbControl.Controls.Add(this.BtnSubmit);
            this.GrbControl.Controls.Add(this.LtbEmergencies);
            this.GrbControl.Controls.Add(this.TxbDesc);
            this.GrbControl.Controls.Add(this.Calendar);
            this.GrbControl.Controls.Add(this.LtbAmbulancias);
            this.GrbControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbControl.Location = new System.Drawing.Point(0, 0);
            this.GrbControl.Name = "GrbControl";
            this.GrbControl.Size = new System.Drawing.Size(770, 420);
            this.GrbControl.TabIndex = 1;
            this.GrbControl.TabStop = false;
            this.GrbControl.Text = "Control";
            // 
            // TxbDesc
            // 
            this.TxbDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbDesc.Location = new System.Drawing.Point(303, 20);
            this.TxbDesc.Multiline = true;
            this.TxbDesc.Name = "TxbDesc";
            this.TxbDesc.ReadOnly = true;
            this.TxbDesc.Size = new System.Drawing.Size(175, 162);
            this.TxbDesc.TabIndex = 2;
            this.TxbDesc.Text = "tipo 1 \r\n12/11/2018\r\nrodeau 219\r\nCOD : 124\r\n";
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(500, 20);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 1;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // LtbAmbulancias
            // 
            this.LtbAmbulancias.BackColor = System.Drawing.Color.Silver;
            this.LtbAmbulancias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtbAmbulancias.FormattingEnabled = true;
            this.LtbAmbulancias.Location = new System.Drawing.Point(10, 20);
            this.LtbAmbulancias.Name = "LtbAmbulancias";
            this.LtbAmbulancias.Size = new System.Drawing.Size(121, 236);
            this.LtbAmbulancias.TabIndex = 0;
            this.LtbAmbulancias.SelectedIndexChanged += new System.EventHandler(this.LtbAmbulancias_SelectedIndexChanged);
            // 
            // GrbControlEmer
            // 
            this.GrbControlEmer.BackColor = System.Drawing.Color.DimGray;
            this.GrbControlEmer.Controls.Add(this.TxbCantEmAtendidas);
            this.GrbControlEmer.Controls.Add(this.Calendario2);
            this.GrbControlEmer.Controls.Add(this.LtbEmergencias);
            this.GrbControlEmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbControlEmer.Location = new System.Drawing.Point(0, 0);
            this.GrbControlEmer.Name = "GrbControlEmer";
            this.GrbControlEmer.Size = new System.Drawing.Size(770, 400);
            this.GrbControlEmer.TabIndex = 2;
            this.GrbControlEmer.TabStop = false;
            this.GrbControlEmer.Text = "Control";
            // 
            // TxbCantEmAtendidas
            // 
            this.TxbCantEmAtendidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCantEmAtendidas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCantEmAtendidas.Location = new System.Drawing.Point(224, 20);
            this.TxbCantEmAtendidas.Multiline = true;
            this.TxbCantEmAtendidas.Name = "TxbCantEmAtendidas";
            this.TxbCantEmAtendidas.ReadOnly = true;
            this.TxbCantEmAtendidas.Size = new System.Drawing.Size(175, 115);
            this.TxbCantEmAtendidas.TabIndex = 2;
            this.TxbCantEmAtendidas.Text = "ATENDIDAS : 5\r\n\r\n";
            // 
            // Calendario2
            // 
            this.Calendario2.Location = new System.Drawing.Point(500, 20);
            this.Calendario2.Name = "Calendario2";
            this.Calendario2.TabIndex = 1;
            // 
            // LtbEmergencias
            // 
            this.LtbEmergencias.BackColor = System.Drawing.Color.Silver;
            this.LtbEmergencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LtbEmergencias.FormattingEnabled = true;
            this.LtbEmergencias.Location = new System.Drawing.Point(10, 20);
            this.LtbEmergencias.Name = "LtbEmergencias";
            this.LtbEmergencias.Size = new System.Drawing.Size(160, 236);
            this.LtbEmergencias.TabIndex = 0;
            // 
            // BtnEmerMen
            // 
            this.BtnEmerMen.Location = new System.Drawing.Point(623, 352);
            this.BtnEmerMen.Name = "BtnEmerMen";
            this.BtnEmerMen.Size = new System.Drawing.Size(125, 52);
            this.BtnEmerMen.TabIndex = 2;
            this.BtnEmerMen.Text = "Emergencia menos atendida";
            this.BtnEmerMen.UseVisualStyleBackColor = true;
            // 
            // LtbEmergencies
            // 
            this.LtbEmergencies.BackColor = System.Drawing.Color.Silver;
            this.LtbEmergencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LtbEmergencies.FormattingEnabled = true;
            this.LtbEmergencies.Location = new System.Drawing.Point(137, 20);
            this.LtbEmergencies.Name = "LtbEmergencies";
            this.LtbEmergencies.Size = new System.Drawing.Size(160, 234);
            this.LtbEmergencies.TabIndex = 3;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(8, 391);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(93, 23);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxbTipo
            // 
            this.TxbTipo.Location = new System.Drawing.Point(125, 287);
            this.TxbTipo.Name = "TxbTipo";
            this.TxbTipo.Size = new System.Drawing.Size(160, 20);
            this.TxbTipo.TabIndex = 5;
            // 
            // TxbDate
            // 
            this.TxbDate.Location = new System.Drawing.Point(125, 313);
            this.TxbDate.Name = "TxbDate";
            this.TxbDate.ReadOnly = true;
            this.TxbDate.Size = new System.Drawing.Size(160, 20);
            this.TxbDate.TabIndex = 6;
            this.TxbDate.Text = "Seleccionar en calendario";
            // 
            // TxbDir
            // 
            this.TxbDir.Location = new System.Drawing.Point(125, 339);
            this.TxbDir.Name = "TxbDir";
            this.TxbDir.Size = new System.Drawing.Size(160, 20);
            this.TxbDir.TabIndex = 7;
            // 
            // TxbCode
            // 
            this.TxbCode.Location = new System.Drawing.Point(125, 365);
            this.TxbCode.Name = "TxbCode";
            this.TxbCode.Size = new System.Drawing.Size(160, 20);
            this.TxbCode.TabIndex = 8;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(8, 294);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(101, 13);
            this.LblType.TabIndex = 9;
            this.LblType.Text = "Tipo de emergencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo de cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TbControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ambulancias";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.TbControl.ResumeLayout(false);
            this.Ambulancias.ResumeLayout(false);
            this.Emergencias.ResumeLayout(false);
            this.GrbControl.ResumeLayout(false);
            this.GrbControl.PerformLayout();
            this.GrbControlEmer.ResumeLayout(false);
            this.GrbControlEmer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbControl;
        private System.Windows.Forms.TabPage Ambulancias;
        private System.Windows.Forms.GroupBox GrbControl;
        private System.Windows.Forms.TextBox TxbDesc;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ListBox LtbAmbulancias;
        private System.Windows.Forms.TabPage Emergencias;
        private System.Windows.Forms.GroupBox GrbControlEmer;
        private System.Windows.Forms.TextBox TxbCantEmAtendidas;
        private System.Windows.Forms.MonthCalendar Calendario2;
        private System.Windows.Forms.ListBox LtbEmergencias;
        private System.Windows.Forms.Button BtnEmerMen;
        private System.Windows.Forms.ListBox LtbEmergencies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.TextBox TxbCode;
        private System.Windows.Forms.TextBox TxbDir;
        private System.Windows.Forms.TextBox TxbDate;
        private System.Windows.Forms.TextBox TxbTipo;
        private System.Windows.Forms.Button BtnSubmit;
    }
}

