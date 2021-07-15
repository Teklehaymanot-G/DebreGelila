namespace FastFoodDemo.ListData
{
    partial class ListDataUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDataUserControl));
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.dB_DebregelilaDataSet = new FastFoodDemo.DB_DebregelilaDataSet();
            this.dBDebregelilaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.general_infoTableAdapter = new FastFoodDemo.DB_DebregelilaDataSetTableAdapters.general_infoTableAdapter();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_general_info_id = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DebregelilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDebregelilaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_main.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_main.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_main.ColumnHeadersHeight = 30;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_main.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_main.EnableHeadersVisualStyles = false;
            this.dgv_main.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_main.Location = new System.Drawing.Point(43, 43);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(731, 289);
            this.dgv_main.TabIndex = 0;
            this.dgv_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellClick);
            this.dgv_main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellContentClick);
            this.dgv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellDoubleClick);
            this.dgv_main.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_main_ColumnHeaderMouseClick);
            this.dgv_main.SelectionChanged += new System.EventHandler(this.dgv_main_SelectionChanged);
            this.dgv_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_main_KeyDown);
            this.dgv_main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_main_KeyUp);
            // 
            // dB_DebregelilaDataSet
            // 
            this.dB_DebregelilaDataSet.DataSetName = "DB_DebregelilaDataSet";
            this.dB_DebregelilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBDebregelilaDataSetBindingSource
            // 
            this.dBDebregelilaDataSetBindingSource.DataSource = this.dB_DebregelilaDataSet;
            this.dBDebregelilaDataSetBindingSource.Position = 0;
            // 
            // generalinfoBindingSource
            // 
            this.generalinfoBindingSource.DataMember = "general_info";
            this.generalinfoBindingSource.DataSource = this.dBDebregelilaDataSetBindingSource;
            // 
            // general_infoTableAdapter
            // 
            this.general_infoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Gray;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(310, 338);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 42);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "  ያጥፉ";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_general_info_id
            // 
            this.txt_general_info_id.Location = new System.Drawing.Point(630, 351);
            this.txt_general_info_id.Name = "txt_general_info_id";
            this.txt_general_info_id.Size = new System.Drawing.Size(100, 20);
            this.txt_general_info_id.TabIndex = 6;
            this.txt_general_info_id.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Gray;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(429, 338);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 42);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "  ያስተካክሉ";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // ListDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_general_info_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_main);
            this.Name = "ListDataUserControl";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.Size = new System.Drawing.Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_DebregelilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDebregelilaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.BindingSource generalinfoBindingSource;
        private System.Windows.Forms.BindingSource dBDebregelilaDataSetBindingSource;
        private DB_DebregelilaDataSet dB_DebregelilaDataSet;
        private DB_DebregelilaDataSetTableAdapters.general_infoTableAdapter general_infoTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_general_info_id;
    }
}
