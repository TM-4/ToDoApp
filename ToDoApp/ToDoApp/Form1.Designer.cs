namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewToDo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRmove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerLimit = new System.Windows.Forms.DateTimePicker();
            this.完了で削除DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.やることDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.期限DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableToDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetToDo = new ToDoApp.dataSetToDo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableToDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewToDo
            // 
            this.dataGridViewToDo.AutoGenerateColumns = false;
            this.dataGridViewToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.完了で削除DataGridViewCheckBoxColumn,
            this.やることDataGridViewTextBoxColumn,
            this.期限DataGridViewTextBoxColumn});
            this.dataGridViewToDo.DataSource = this.dataTableToDoBindingSource;
            this.dataGridViewToDo.Location = new System.Drawing.Point(18, 12);
            this.dataGridViewToDo.Name = "dataGridViewToDo";
            this.dataGridViewToDo.RowTemplate.Height = 21;
            this.dataGridViewToDo.Size = new System.Drawing.Size(418, 284);
            this.dataGridViewToDo.TabIndex = 0;
            this.dataGridViewToDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewToDoCellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "やること";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "期限";
            // 
            // txtToDo
            // 
            this.txtToDo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDo.Location = new System.Drawing.Point(47, 366);
            this.txtToDo.Name = "txtToDo";
            this.txtToDo.Size = new System.Drawing.Size(188, 33);
            this.txtToDo.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(271, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 47);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "登録";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClicked);
            // 
            // btnRmove
            // 
            this.btnRmove.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmove.Location = new System.Drawing.Point(271, 392);
            this.btnRmove.Name = "btnRmove";
            this.btnRmove.Size = new System.Drawing.Size(99, 47);
            this.btnRmove.TabIndex = 6;
            this.btnRmove.Text = "削除";
            this.btnRmove.UseVisualStyleBackColor = true;
            this.btnRmove.Click += new System.EventHandler(this.BtnRmoveClicked);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(271, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClicked);
            // 
            // dateTimePickerLimit
            // 
            this.dateTimePickerLimit.Location = new System.Drawing.Point(47, 462);
            this.dateTimePickerLimit.Name = "dateTimePickerLimit";
            this.dateTimePickerLimit.Size = new System.Drawing.Size(188, 19);
            this.dateTimePickerLimit.TabIndex = 8;
            // 
            // 完了で削除DataGridViewCheckBoxColumn
            // 
            this.完了で削除DataGridViewCheckBoxColumn.DataPropertyName = "完了(☑で削除)";
            this.完了で削除DataGridViewCheckBoxColumn.HeaderText = "完了(☑で削除)";
            this.完了で削除DataGridViewCheckBoxColumn.Name = "完了で削除DataGridViewCheckBoxColumn";
            // 
            // やることDataGridViewTextBoxColumn
            // 
            this.やることDataGridViewTextBoxColumn.DataPropertyName = "やること";
            this.やることDataGridViewTextBoxColumn.HeaderText = "やること";
            this.やることDataGridViewTextBoxColumn.Name = "やることDataGridViewTextBoxColumn";
            // 
            // 期限DataGridViewTextBoxColumn
            // 
            this.期限DataGridViewTextBoxColumn.DataPropertyName = "期限";
            this.期限DataGridViewTextBoxColumn.HeaderText = "期限";
            this.期限DataGridViewTextBoxColumn.Name = "期限DataGridViewTextBoxColumn";
            // 
            // dataTableToDoBindingSource
            // 
            this.dataTableToDoBindingSource.DataMember = "dataTableToDo";
            this.dataTableToDoBindingSource.DataSource = this.dataSetToDo;
            // 
            // dataSetToDo
            // 
            this.dataSetToDo.DataSetName = "dataSetToDo";
            this.dataSetToDo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 521);
            this.Controls.Add(this.dateTimePickerLimit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRmove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtToDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewToDo);
            this.Name = "Form1";
            this.Text = "ToDoApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableToDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToDo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRmove;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完了DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 完了DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 完了で削除DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn やることDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 期限DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableToDoBindingSource;
        private dataSetToDo dataSetToDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerLimit;
    }
}

