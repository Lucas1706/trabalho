
namespace tcc
{
    partial class consulta_falecido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdigite_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.banco_velorioDataSet2 = new tcc.banco_velorioDataSet2();
            this.banco_VelorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_VelorioTableAdapter = new tcc.banco_velorioDataSet2TableAdapters.Banco_VelorioTableAdapter();
            this.tableAdapterManager = new tcc.banco_velorioDataSet2TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.banco_velorioDataSet3 = new tcc.banco_velorioDataSet3();
            this.banco_VelorioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.banco_VelorioTableAdapter1 = new tcc.banco_velorioDataSet3TableAdapters.Banco_VelorioTableAdapter();
            this.tableAdapterManager1 = new tcc.banco_velorioDataSet3TableAdapters.TableAdapterManager();
            this.banco_VelorioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banco_velorioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_velorioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta nome do falecido";
            // 
            // txtdigite_nome
            // 
            this.txtdigite_nome.Location = new System.Drawing.Point(83, 88);
            this.txtdigite_nome.Name = "txtdigite_nome";
            this.txtdigite_nome.Size = new System.Drawing.Size(169, 20);
            this.txtdigite_nome.TabIndex = 1;
            this.txtdigite_nome.TextChanged += new System.EventHandler(this.txtdigite_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o nome do falecido";
            // 
            // banco_velorioDataSet2
            // 
            this.banco_velorioDataSet2.DataSetName = "banco_velorioDataSet2";
            this.banco_velorioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banco_VelorioBindingSource
            // 
            this.banco_VelorioBindingSource.DataMember = "Banco_Velorio";
            this.banco_VelorioBindingSource.DataSource = this.banco_velorioDataSet2;
            // 
            // banco_VelorioTableAdapter
            // 
            this.banco_VelorioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Banco_VelorioTableAdapter = this.banco_VelorioTableAdapter;
            this.tableAdapterManager.UpdateOrder = tcc.banco_velorioDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // banco_velorioDataSet3
            // 
            this.banco_velorioDataSet3.DataSetName = "banco_velorioDataSet3";
            this.banco_velorioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banco_VelorioBindingSource1
            // 
            this.banco_VelorioBindingSource1.DataMember = "Banco_Velorio";
            this.banco_VelorioBindingSource1.DataSource = this.banco_velorioDataSet3;
            // 
            // banco_VelorioTableAdapter1
            // 
            this.banco_VelorioTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Banco_VelorioTableAdapter = this.banco_VelorioTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = tcc.banco_velorioDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // banco_VelorioDataGridView
            // 
            this.banco_VelorioDataGridView.AutoGenerateColumns = false;
            this.banco_VelorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banco_VelorioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.banco_VelorioDataGridView.DataSource = this.banco_VelorioBindingSource1;
            this.banco_VelorioDataGridView.Location = new System.Drawing.Point(83, 189);
            this.banco_VelorioDataGridView.Name = "banco_VelorioDataGridView";
            this.banco_VelorioDataGridView.ReadOnly = true;
            this.banco_VelorioDataGridView.Size = new System.Drawing.Size(1153, 220);
            this.banco_VelorioDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_falecido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_falecido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_falecimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_falecimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nacionalidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nacionalidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data_nascimento_Falecido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data_nascimento_Falecido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Naturalidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Naturalidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome_da_Mãe";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome_da_Mãe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Nome_do_Pai";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome_do_Pai";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tumulo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tumulo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Historico_do_falecido";
            this.dataGridViewTextBoxColumn10.HeaderText = "Historico_do_falecido";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.Width = 154;
            // 
            // consulta_falecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1262, 544);
            this.Controls.Add(this.banco_VelorioDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdigite_nome);
            this.Controls.Add(this.label1);
            this.Name = "consulta_falecido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta do Falecido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco_velorioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_velorioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_VelorioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdigite_nome;
        private System.Windows.Forms.Label label2;
        private banco_velorioDataSet2 banco_velorioDataSet2;
        private System.Windows.Forms.BindingSource banco_VelorioBindingSource;
        private banco_velorioDataSet2TableAdapters.Banco_VelorioTableAdapter banco_VelorioTableAdapter;
        private banco_velorioDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private banco_velorioDataSet3 banco_velorioDataSet3;
        private System.Windows.Forms.BindingSource banco_VelorioBindingSource1;
        private banco_velorioDataSet3TableAdapters.Banco_VelorioTableAdapter banco_VelorioTableAdapter1;
        private banco_velorioDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView banco_VelorioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}