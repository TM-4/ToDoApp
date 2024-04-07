using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///エンターキーで登録ボタン押下
            AcceptButton = btnAdd;
            BackColor = Color.LightGray;
        }

        /// <summary>
        /// 登録ボタンを押したら行を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BtnAddClicked
        private void BtnAddClicked(object sender, EventArgs e)
        {
            DateTime limitDateValue = dateTimePickerLimit.Value;
            string limitDateString = limitDateValue.ToShortDateString();

            dataSetToDo.dataTableToDo.AdddataTableToDoRow(
            false,
            this.txtToDo.Text,
            DateTime.Parse(limitDateString));
        }
        #endregion

        /// <summary>
        /// 削除ボタンを押したら行を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BtnRmoveClicked
        private void BtnRmoveClicked(object sender, EventArgs e)
        {
            if (dataGridViewToDo.CurrentRow != null)
            {
                int row = dataGridViewToDo.CurrentRow.Index;
                this.dataGridViewToDo.Rows.RemoveAt(row);
            }
        }
        #endregion

        /// <summary>
        /// データグリッドビュー内のチェックボックスが押下された際に行を削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region DataGridViewToDoCellContentClick
        private void DataGridViewToDoCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewToDo.Columns[e.ColumnIndex].Name == "完了で削除DataGridViewCheckBoxColumn")
            {
                bool isChecked = (bool)dataGridViewToDo[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                if (isChecked)
                {
                    dataGridViewToDo.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        #endregion

        /// <summary>
        /// 保存ボタンを押したらファイルに保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region BtnSaveClicked
        private void BtnSaveClicked(object sender, EventArgs e)
        {
            if (dataGridViewToDo.CurrentRow != null)
            {
                int currentRowIndex = dataGridViewToDo.CurrentRow.Index;
                string currentRowTextToDo = dataGridViewToDo.Rows[currentRowIndex].Cells["やることDataGridViewTextBoxColumn"].Value.ToString();
                string currentRowTextLimit = dataGridViewToDo.Rows[currentRowIndex].Cells["期限DataGridViewTextBoxColumn"].Value.ToString();

                DateTime limitDateValue = dateTimePickerLimit.Value;
                string limitDateString = limitDateValue.ToShortDateString();
                string currentRowText = currentRowTextToDo + "," + limitDateString;
                File.AppendAllText("ToDoApp.txt", currentRowText + Environment.NewLine);
            }
        }
        #endregion
    }
}