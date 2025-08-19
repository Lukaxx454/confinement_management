namespace confinement_management
{
    partial class FrmEditUsuario
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cJ3027791PR2DataSet = new confinement_management.CJ3027791PR2DataSet();
            this.cADUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADUTableAdapter = new confinement_management.CJ3027791PR2DataSetTableAdapters.CADUTableAdapter();
            this.iDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASCIMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAZENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDEREÇODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sENHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027791PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUSUARIODataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.nASCIMENTODataGridViewTextBoxColumn,
            this.fAZENDADataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.eNDEREÇODataGridViewTextBoxColumn,
            this.sENHADataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cADUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // cJ3027791PR2DataSet
            // 
            this.cJ3027791PR2DataSet.DataSetName = "CJ3027791PR2DataSet";
            this.cJ3027791PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADUBindingSource
            // 
            this.cADUBindingSource.DataMember = "CADU";
            this.cADUBindingSource.DataSource = this.cJ3027791PR2DataSet;
            // 
            // cADUTableAdapter
            // 
            this.cADUTableAdapter.ClearBeforeFill = true;
            // 
            // iDUSUARIODataGridViewTextBoxColumn
            // 
            this.iDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO";
            this.iDUSUARIODataGridViewTextBoxColumn.Name = "iDUSUARIODataGridViewTextBoxColumn";
            this.iDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // nASCIMENTODataGridViewTextBoxColumn
            // 
            this.nASCIMENTODataGridViewTextBoxColumn.DataPropertyName = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.HeaderText = "NASCIMENTO";
            this.nASCIMENTODataGridViewTextBoxColumn.Name = "nASCIMENTODataGridViewTextBoxColumn";
            // 
            // fAZENDADataGridViewTextBoxColumn
            // 
            this.fAZENDADataGridViewTextBoxColumn.DataPropertyName = "FAZENDA";
            this.fAZENDADataGridViewTextBoxColumn.HeaderText = "FAZENDA";
            this.fAZENDADataGridViewTextBoxColumn.Name = "fAZENDADataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // eNDEREÇODataGridViewTextBoxColumn
            // 
            this.eNDEREÇODataGridViewTextBoxColumn.DataPropertyName = "ENDEREÇO";
            this.eNDEREÇODataGridViewTextBoxColumn.HeaderText = "ENDEREÇO";
            this.eNDEREÇODataGridViewTextBoxColumn.Name = "eNDEREÇODataGridViewTextBoxColumn";
            // 
            // sENHADataGridViewTextBoxColumn
            // 
            this.sENHADataGridViewTextBoxColumn.DataPropertyName = "SENHA";
            this.sENHADataGridViewTextBoxColumn.HeaderText = "SENHA";
            this.sENHADataGridViewTextBoxColumn.Name = "sENHADataGridViewTextBoxColumn";
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            // 
            // FrmEditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 464);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmEditUsuario";
            this.Text = "FrmEditUsuario";
            this.Load += new System.EventHandler(this.FrmEditUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3027791PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CJ3027791PR2DataSet cJ3027791PR2DataSet;
        private System.Windows.Forms.BindingSource cADUBindingSource;
        private CJ3027791PR2DataSetTableAdapters.CADUTableAdapter cADUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASCIMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAZENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDEREÇODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sENHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
    }
}